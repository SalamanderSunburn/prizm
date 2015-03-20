﻿using Prizm.Data.DAL.Construction;
using Prizm.Domain.Entity.Construction;
using NHibernate;
using NHibernate.Exceptions;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;

namespace Prizm.Data.DAL.Hibernate
{
    public class JointRepository : AbstractHibernateRepository<Guid, Joint>, IJointRepository
    {
        [Inject]
        public JointRepository(ISession session)
            : base(session)
        {
        }
        
        #region IJointRepository Members
        
        public IList<Joint> GetActiveByNumber(Joint joint)
        {
            try
            {
                return session.QueryOver<Joint>().Where(_ => _.IsActive == true && _.Id != joint.Id && _.Number == joint.Number).List<Joint>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetActiveByNumber", ex);
            }
        }

        public IList<Joint> GetJointsToExport()
        {
           try
           {
              return session.QueryOver<Joint>().Where(_ => _.ToExport).List<Joint>();
           }
           catch (GenericADOException ex)
           {
              throw new RepositoryException("GetJointsToExport", ex);
           }
        }

        public IList<Joint> SearchJoint(string jointNumber, IList<JointStatus> statuses, DateTime? from, DateTime? to, string peg, bool? status)
        {

            var jointWithWeld = QueryOver.Of<Joint>()
                .JoinQueryOver<JointWeldResult>(j => j.JointWeldResults)
                .Select(Projections.Distinct(Projections.Property<Joint>(j => j.JointWeldResults)));
            if(from != null && from != DateTime.MinValue)
            {
                jointWithWeld.Where(f => f.Date >= from);
            }
            if(to != null && to != DateTime.MinValue)
            {
                jointWithWeld.Where(t => t.Date <= to);
            }

            
            var q = session.QueryOver<Joint>();
            // joint number
            if(!string.IsNullOrWhiteSpace(jointNumber))
            {
                q.WhereRestrictionOn(n => n.Number).IsLike(jointNumber, MatchMode.Start);
            }
            // statuses
            q.WhereRestrictionOn(x => x.Status).IsIn(statuses.ToArray());
            // status
            if(status != null)
            {
                q.Where(x => x.IsActive == status);
            }
            //peg
            if(!string.IsNullOrWhiteSpace(peg))
            {
                int number = Convert.ToInt32(peg);
                q.Where(x => x.NumberKP == number);
            }

            
            q.WithSubquery
                .WhereProperty(j => j.JointWeldResults)
                .In(jointWithWeld);


            return q.List<Joint>();
        }


        public IList<Joint> GetJointsForTracing()
        {
            try
            {
                return 
                    session.CreateCriteria<Joint>()
                    .SetProjection(Projections.ProjectionList()
                        .Add(Projections.Property("FirstElement"), "FirstElement")
                        .Add(Projections.Property("SecondElement"), "SecondElement")
                        .Add(Projections.Property("Number"), "Number")
                        .Add(Projections.Property("Id"), "Id")
                        .Add(Projections.Property("IsActive"), "IsActive")
                        .Add(Projections.Property("Status"), "Status")
                        .Add(Projections.Property("LoweringDate"), "LoweringDate")
                        .Add(Projections.Property("DistanceFromKP"), "DistanceFromKP")
                        .Add(Projections.Property("NumberKP"), "NumberKP")
                     ).SetResultTransformer(Transformers.AliasToBean<Joint>())
                     .Add(Restrictions.Eq("IsActive", true))
                     .Add(Restrictions.IsNotNull("FirstElement"))
                     .Add(Restrictions.IsNotNull("SecondElement"))
                     .Add(Restrictions.Not(Restrictions.Eq("Status", JointStatus.Withdrawn)))
                     .AddOrder(Order.Asc("Number"))
                     .List<Joint>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetJointsForTracing", ex);
            }
        }

        public ICriteria GetJointsProjections()
        {
            try
            {
                return
                    session.CreateCriteria<Joint>()
                    .Add(Restrictions.Eq("IsActive", true))
                    .Add(Restrictions.IsNotNull("FirstElement"))
                    .Add(Restrictions.IsNotNull("SecondElement"))
                    .Add(Restrictions.Not(Restrictions.Eq("Status", JointStatus.Withdrawn)))
                    .AddOrder(Order.Asc("Number"))
                    .SetProjection(Projections.ProjectionList()
                        .Add(Projections.Property("Number"), "Number")
                        .Add(Projections.Property("Id"), "Id")
                        .Add(Projections.Property("NumberKP"), "NumberKP")
                     );
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetJointsForTracing", ex);
            }
        }

        #endregion
    }
}
