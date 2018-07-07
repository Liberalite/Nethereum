using System.Collections;
using Loom.Nethereum.Contracts.CQS;
using Loom.Nethereum.Hex.HexTypes;

namespace Loom.Nethereum.JsonRpc.UnityClient
{
    public class EstimateContractTransactionUnityRequest : UnityRequest<HexBigInteger>
    {
        private string _url;
        private readonly EthEstimateGasUnityRequest _ethEstimateGasUnityRequest;

        public EstimateContractTransactionUnityRequest(string url, string privateKey, string account)
        {
            _url = url;
            _ethEstimateGasUnityRequest = new EthEstimateGasUnityRequest(url);
        }

        public IEnumerator EstimateContractFunction<TContractFunction>(TContractFunction function, string contractAdress) where TContractFunction : FunctionMessage
        {
            var callInput = function.CreateCallInput(contractAdress);
            yield return _ethEstimateGasUnityRequest.SendRequest(callInput);
        }

        public IEnumerator EstimateContractDeployment<TDeploymentMessage>(TDeploymentMessage deploymentMessage) where TDeploymentMessage : ContractDeploymentMessage
        {
            var callInput = deploymentMessage.CreateCallInput();
            yield return _ethEstimateGasUnityRequest.SendRequest(callInput);
        }
    }
}