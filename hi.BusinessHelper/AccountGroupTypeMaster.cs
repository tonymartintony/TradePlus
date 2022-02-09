using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Data; 
using hi.DataHelper; 
using hi.BoUtilitys;
namespace hi.BusinessHelper
{
    public class AccountGroupTypeMaster : BoHelper
    {
        #region Constructor
        /// <summary>  
        /// Default Constructor for CsBranch  
        /// </summary>  
        public AccountGroupTypeMaster()
        {
            if (!IsInitialized)
                throw new Exception("Initialization Failed");
        }
        #endregion

        #region PublicProperties
        public int AccountGroupTypeId { get; set; }
        public string AccountGroupType { get; set; }
        public string AccountGroupAlias { get; set; }

        #endregion


        #region Methods
        /// To Do : Add necessary params and conditions   

        public RetrievableObjects SelectAccountTypeDW()
        {

            using (var connection = DbHelper.GetConnObject())
            {
                var paramCollection = new DbParameterCollection();
                /// To Do : Add necessary params and conditions   

                using (var reader = DbHelper.ExecuteDataReader(AccountGroupTypeMasterConstants.SelectAccountTypeDW, connection, paramCollection, CommandType.Text))
                {
                    HiRetrievableObjects.RetrievableDataTable.Load(reader);
                }
            }

            return HiRetrievableObjects;
        }
        public RetrievableObjects Select()
        {

            using (var connection = DbHelper.GetConnObject())
            {
                var paramCollection = new DbParameterCollection();
                /// To Do : Add necessary params and conditions   

                using (var reader = DbHelper.ExecuteDataReader(AccountGroupTypeMasterConstants.SelectCommand, connection, paramCollection, CommandType.Text))
                {
                    HiRetrievableObjects.RetrievableDataTable.Load(reader);
                }
            }

            return HiRetrievableObjects;
        }


        public RetrievableObjects SelectWithId()
        {
            using (var connection = DbHelper.GetConnObject())
            {
                var paramCollection = new DbParameterCollection();
                paramCollection.Add(new DbParameter("@account_group_type_id", AccountGroupTypeId));  /// to be varified  
                using (var reader = DbHelper.ExecuteDataReader(AccountGroupTypeMasterConstants.SelectWithIdCommand, connection, paramCollection, CommandType.Text))
                {
                    HiRetrievableObjects.RetrievableDataTable.Load(reader);
                }
            }

            return HiRetrievableObjects;
        }

        /// To Do : Add necessary params and conditions   
        public RetrievableObjects OverViewSelect()
        {

            using (var connection = DbHelper.GetConnObject())
            {
                string CommandCondition = "";
                var paramCollection = new DbParameterCollection();
                /// To Do : Add necessary params and conditions   

                using (var reader = DbHelper.ExecuteDataReader(AccountGroupTypeMasterConstants.OverviewSelectCommand + CommandCondition, connection, paramCollection, CommandType.Text))
                {
                    HiRetrievableObjects.RetrievableDataTable.Load(reader);
                }
            }

            return HiRetrievableObjects;
        }

        public RetrievableObjects Insert()
        {
            var paramCollection = new DbParameterCollection();
            paramCollection.Add(new DbParameter("@tAction", 1));
            paramCollection.Add(new DbParameter("@account_group_type_id", AccountGroupTypeId));
            paramCollection.Add(new DbParameter("@account_group_type", AccountGroupType));
            paramCollection.Add(new DbParameter("@account_group_alias", AccountGroupAlias));

            try
            {
                using (var command = DbHelper.GetCommand(AccountGroupTypeMasterConstants.UpdateProcedureName, paramCollection, CommandType.StoredProcedure))
                {
                    command.ExecuteNonQuery();
                    HiRetrievableObjects.RetrievableString = "Executed Sucessfully";
                }
            }
            catch (Exception ex)
            {
                HiRetrievableObjects.RetrievableString = "Exception";
                HiRetrievableObjects.RetrievableExceptions.Add(new BoException(ex.Message, ex.Source, ex));
            }

            return HiRetrievableObjects;
        }

        public RetrievableObjects Update()
        {
            var paramCollection = new DbParameterCollection();
            paramCollection.Add(new DbParameter("@tAction", 2));
            paramCollection.Add(new DbParameter("@account_group_type_id", AccountGroupTypeId));
            paramCollection.Add(new DbParameter("@account_group_type", AccountGroupType));
            paramCollection.Add(new DbParameter("@account_group_alias", AccountGroupAlias));
            try
            {
                using (var command = DbHelper.GetCommand(AccountGroupTypeMasterConstants.UpdateProcedureName, paramCollection, CommandType.StoredProcedure))
                {
                    command.ExecuteNonQuery();
                    HiRetrievableObjects.RetrievableString = "Executed Sucessfully";
                }
            }
            catch (Exception ex)
            {
                HiRetrievableObjects.RetrievableString = "Exception";
                HiRetrievableObjects.RetrievableExceptions.Add(new BoException(ex.Message, ex.Source, ex));
            }

            return HiRetrievableObjects;
        }

        public RetrievableObjects Delete()
        {
            var paramCollection = new DbParameterCollection();
            paramCollection.Add(new DbParameter("@tAction", 3));
            paramCollection.Add(new DbParameter("@account_group_type_id", AccountGroupTypeId));
            try
            {
                using (var command = DbHelper.GetCommand(AccountGroupTypeMasterConstants.UpdateProcedureName, paramCollection, CommandType.StoredProcedure))
                {
                    command.ExecuteNonQuery();
                    HiRetrievableObjects.RetrievableString = "Executed Sucessfully";
                }
            }
            catch (Exception ex)
            {
                HiRetrievableObjects.RetrievableString = "Exception";
                HiRetrievableObjects.RetrievableExceptions.Add(new BoException(ex.Message, ex.Source, ex));
            }

            return HiRetrievableObjects;
        }
        #endregion

    }
    public class ReturnAccounttype
    {
        public int account_group_type_id { get; set; }
        public string account_group_type { get; set; }

    }
}
