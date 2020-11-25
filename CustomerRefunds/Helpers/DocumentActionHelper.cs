using DefenderERP;
using System;
using System.Threading.Tasks;

namespace CustomerRefunds.Helpers
{
    public abstract class DocumentActionsHelper : IDisposable
    {
        #region -----  consts  -----
        private const int EventType = 1;
        private const int AccountIndex_Dist1 = 12910;
        private const int AccountIndex_Dist2 = 6;
        public const string CompanyID = "DFND";

        public const string Error_CreateCreditMemo = "CRDHCM:1";
        public const string Error_DocActionHelper_Log = "CRDHIT:1";
        public const string Error_DocActionHelper_Type = "CRDHIT:2";
        #endregion -----  consts  -----

        #region -----  vars  -----
        internal long ClientLogID;
        internal string BatchNumber;
        internal GPTypes DocTypes;
        internal DateTime ProcessDT;
        internal DocumentActionsSoapClient DocClient;
        #endregion -----  vars  -----

        internal async Task<ResultSet> InitSoap(string username)
        {
            this.DocClient = new DocumentActionsSoapClient(DocumentActionsSoapClient.EndpointConfiguration.DocumentActionsSoap);
            this.ProcessDT = DateTime.Now;

            try
            {
                this.ClientLogID = await this.DocClient.GetAccountingProcessLogIdAsync(DocumentActionsHelper.EventType, username);
            }
            catch ( Exception doneGotsError )
            {
                return ResultSet.MakeError(DocumentActionsHelper.Error_DocActionHelper_Log, doneGotsError);
            }

            try
            {
                var docCall = await this.DocClient.GetTypesAsync();

                this.DocTypes = docCall.GetTypesResult;
            }
            catch ( Exception gotsError )
            {
                return ResultSet.MakeError(DocumentActionsHelper.Error_DocActionHelper_Type, gotsError);
            }

            return ResultSet.MakeGood();
        }

        internal async Task<GLAccount[]> GetDistributionIndexes()
        {
            var callDist0 = await this.DocClient.GetGLAccountByIndexAsync(DocumentActionsHelper.AccountIndex_Dist1, DocumentActionsHelper.CompanyID, this.ClientLogID);
            var callDist1 = await this.DocClient.GetGLAccountByIndexAsync(DocumentActionsHelper.AccountIndex_Dist2, DocumentActionsHelper.CompanyID, this.ClientLogID);

            return new GLAccount[]
            {
                callDist0.GetGLAccountByIndexResult,
                callDist1.GetGLAccountByIndexResult
            };
        }

        public void Dispose()
        {
            if ( this.DocClient != null )
            {
                this.DocClient.CloseAsync();
            }
        }
    }
}