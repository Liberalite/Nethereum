using System;
using System.Threading.Tasks;
using System.Numerics;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.Contracts.CQS;
using Loom.Nethereum.ABI.FunctionEncoding.Attributes;
namespace SolidityCallAnotherContract.Contracts.TheOther.CQS
{
    public class TheOtherDeployment:ContractDeploymentMessage
    {
        
        public static string BYTECODE = "608060405234801561001057600080fd5b50610368806100206000396000f3006080604052600436106100405763ffffffff7c010000000000000000000000000000000000000000000000000000000060003504166343ea0aa58114610045575b600080fd5b34801561005157600080fd5b506100656100603660046101df565b61007b565b604051610072919061027d565b60405180910390f35b6060828260405160200180807f48656c6c6f20000000000000000000000000000000000000000000000000000081525060060183805190602001908083835b602083106100d95780518252601f1990920191602091820191016100ba565b6001836020036101000a038019825116818451168082178552505050505050905001807f200000000000000000000000000000000000000000000000000000000000000081525060010182805190602001908083835b6020831061014e5780518252601f19909201916020918201910161012f565b6001836020036101000a03801982511681845116808217855250505050505090500192505050604051602081830303815290604052905092915050565b6000601f8201831361019c57600080fd5b81356101af6101aa826102bc565b610295565b915080825260208301602083018583830111156101cb57600080fd5b6101d68382846102e8565b50505092915050565b600080604083850312156101f257600080fd5b823567ffffffffffffffff81111561020957600080fd5b6102158582860161018b565b925050602083013567ffffffffffffffff81111561023257600080fd5b61023e8582860161018b565b9150509250929050565b6000610253826102e4565b8084526102678160208601602086016102f4565b61027081610324565b9093016020019392505050565b6020808252810161028e8184610248565b9392505050565b60405181810167ffffffffffffffff811182821017156102b457600080fd5b604052919050565b600067ffffffffffffffff8211156102d357600080fd5b506020601f91909101601f19160190565b5190565b82818337506000910152565b60005b8381101561030f5781810151838201526020016102f7565b8381111561031e576000848401525b50505050565b601f01601f1916905600a265627a7a723058202eeb3da2a7bee9d01f64d888c75c7a65f9990d3a4f64529bffa8c73595be5ca86c6578706572696d656e74616cf50037";
        
        public TheOtherDeployment():base(BYTECODE) { }
        
        public TheOtherDeployment(string byteCode):base(byteCode) { }
        

    }
}
