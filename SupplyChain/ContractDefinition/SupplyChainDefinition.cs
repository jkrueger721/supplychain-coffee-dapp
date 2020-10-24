using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Project6.Contracts.SupplyChain.ContractDefinition
{


    public partial class SupplyChainDeployment : SupplyChainDeploymentBase
    {
        public SupplyChainDeployment() : base(BYTECODE) { }
        public SupplyChainDeployment(string byteCode) : base(byteCode) { }
    }

    public class SupplyChainDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405261000d3361002c565b600180546001600160a01b0319163317815560038190556002556100fc565b61004481600061007b60201b61094d1790919060201c565b6040516001600160a01b038216907f2e0ded4123377a3c2bc9a26f1717655a129e2f20752924d42e730ec89c83dbd090600090a250565b6001600160a01b03811661008e57600080fd5b61009882826100c7565b156100a257600080fd5b6001600160a01b0316600090815260209190915260409020805460ff19166001179055565b60006001600160a01b0382166100dc57600080fd5b506001600160a01b03166000908152602091909152604090205460ff1690565b610ad08061010b6000396000f3fe6080604052600436106101405760003560e01c806380fc0ce4116100b6578063bdd8a6a81161006f578063bdd8a6a8146105b7578063d38ea5bf146101bf578063db0e6a2f14610230578063e7fb74c714610891578063f30fc480146101bf578063f61c899a146101bf57610140565b806380fc0ce41461056f578063834ff739146101e95780638ec4f505146101455780638f0c86fa146101e9578063a26be999146101bf578063b94290691461058457610140565b806361e6982d1161010857806361e6982d14610230578063644241db1461023057806366225ff9146102455780637250e2241461014557806377c459131461033a57806380c3f96d1461053c57610140565b8063112940f9146101455780632d9235611461017a57806341c0e1b5146101aa57806349dae766146101bf5780635da09b88146101e9575b600080fd5b34801561015157600080fd5b506101786004803603602081101561016857600080fd5b50356001600160a01b03166108a7565b005b34801561018657600080fd5b506101786004803603604081101561019d57600080fd5b50803590602001356108aa565b3480156101b657600080fd5b506101786108ae565b3480156101cb57600080fd5b50610178600480360360208110156101e257600080fd5b50356108a7565b3480156101f557600080fd5b5061021c6004803603602081101561020c57600080fd5b50356001600160a01b03166108d1565b604080519115158252519081900360200190f35b34801561023c57600080fd5b506101786108cf565b34801561025157600080fd5b5061026f6004803603602081101561026857600080fd5b50356108d7565b604051808a815260200189815260200188815260200180602001878152602001868152602001856001600160a01b03168152602001846001600160a01b03168152602001836001600160a01b03168152602001828103825288818151815260200191508051906020019080838360005b838110156102f75781810151838201526020016102df565b50505050905090810190601f1680156103245780820380516001836020036101000a031916815260200191505b509a505050505050505050505060405180910390f35b34801561034657600080fd5b506103646004803603602081101561035d57600080fd5b50356108ee565b60405180898152602001888152602001876001600160a01b03168152602001866001600160a01b0316815260200180602001806020018060200180602001858103855289818151815260200191508051906020019080838360005b838110156103d75781810151838201526020016103bf565b50505050905090810190601f1680156104045780820380516001836020036101000a031916815260200191505b5085810384528851815288516020918201918a019080838360005b8381101561043757818101518382015260200161041f565b50505050905090810190601f1680156104645780820380516001836020036101000a031916815260200191505b50858103835287518152875160209182019189019080838360005b8381101561049757818101518382015260200161047f565b50505050905090810190601f1680156104c45780820380516001836020036101000a031916815260200191505b50858103825286518152865160209182019188019080838360005b838110156104f75781810151838201526020016104df565b50505050905090810190601f1680156105245780820380516001836020036101000a031916815260200191505b509c5050505050505050505050505060405180910390f35b34801561054857600080fd5b506101786004803603602081101561055f57600080fd5b50356001600160a01b0316610905565b34801561057b57600080fd5b50610178610920565b34801561059057600080fd5b5061021c600480360360208110156105a757600080fd5b50356001600160a01b0316610929565b3480156105c357600080fd5b50610178600480360360e08110156105da57600080fd5b8135916001600160a01b0360208201351691810190606081016040820135600160201b81111561060957600080fd5b82018360208201111561061b57600080fd5b803590602001918460018302840111600160201b8311171561063c57600080fd5b91908080601f0160208091040260200160405190810160405280939291908181526020018383808284376000920191909152509295949360208101935035915050600160201b81111561068e57600080fd5b8201836020820111156106a057600080fd5b803590602001918460018302840111600160201b831117156106c157600080fd5b91908080601f0160208091040260200160405190810160405280939291908181526020018383808284376000920191909152509295949360208101935035915050600160201b81111561071357600080fd5b82018360208201111561072557600080fd5b803590602001918460018302840111600160201b8311171561074657600080fd5b91908080601f0160208091040260200160405190810160405280939291908181526020018383808284376000920191909152509295949360208101935035915050600160201b81111561079857600080fd5b8201836020820111156107aa57600080fd5b803590602001918460018302840111600160201b831117156107cb57600080fd5b91908080601f0160208091040260200160405190810160405280939291908181526020018383808284376000920191909152509295949360208101935035915050600160201b81111561081d57600080fd5b82018360208201111561082f57600080fd5b803590602001918460018302840111600160201b8311171561085057600080fd5b91908080601f01602080910402602001604051908101604052809392919081815260200183838082843760009201919091525092955061093b945050505050565b610178600480360360208110156101e257600080fd5b50565b5050565b6001546001600160a01b03163314156108cf576001546001600160a01b0316ff5b565b50600090565b506000908190819060609082908190819081908190565b600080600080606080606080919395975091939597565b61090e33610929565b61091757600080fd5b6108a781610999565b6108cf336109db565b60006109358183610a1d565b92915050565b50506003805460010190555050505050565b6001600160a01b03811661096057600080fd5b61096a8282610a1d565b1561097457600080fd5b6001600160a01b0316600090815260209190915260409020805460ff19166001179055565b6109a460008261094d565b6040516001600160a01b038216907f2e0ded4123377a3c2bc9a26f1717655a129e2f20752924d42e730ec89c83dbd090600090a250565b6109e6600082610a52565b6040516001600160a01b038216907fa5e0f060af304ab17dd418c7927e3da3ae7868189bf387aee09ab179ccc572f290600090a250565b60006001600160a01b038216610a3257600080fd5b506001600160a01b03166000908152602091909152604090205460ff1690565b6001600160a01b038116610a6557600080fd5b610a6f8282610a1d565b610a7857600080fd5b6001600160a01b0316600090815260209190915260409020805460ff1916905556fea26469706673582212202b2777e69dd0cefb6c62c1cd56d9d787ff80f7e87c1c4e2ddf82274f1d3b709564736f6c63430007000033";
        public SupplyChainDeploymentBase() : base(BYTECODE) { }
        public SupplyChainDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class AddConsumerFunction : AddConsumerFunctionBase { }

    [Function("addConsumer")]
    public class AddConsumerFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class AddDistributorFunction : AddDistributorFunctionBase { }

    [Function("addDistributor")]
    public class AddDistributorFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class AddFarmerFunction : AddFarmerFunctionBase { }

    [Function("addFarmer")]
    public class AddFarmerFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class AddRetailerFunction : AddRetailerFunctionBase { }

    [Function("addRetailer")]
    public class AddRetailerFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class BuyItemFunction : BuyItemFunctionBase { }

    [Function("buyItem")]
    public class BuyItemFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_upc", 1)]
        public virtual BigInteger Upc { get; set; }
    }

    public partial class FetchItemBufferOneFunction : FetchItemBufferOneFunctionBase { }

    [Function("fetchItemBufferOne", typeof(FetchItemBufferOneOutputDTO))]
    public class FetchItemBufferOneFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_upc", 1)]
        public virtual BigInteger Upc { get; set; }
    }

    public partial class FetchItemBufferTwoFunction : FetchItemBufferTwoFunctionBase { }

    [Function("fetchItemBufferTwo", typeof(FetchItemBufferTwoOutputDTO))]
    public class FetchItemBufferTwoFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_upc", 1)]
        public virtual BigInteger Upc { get; set; }
    }

    public partial class HarvestItemFunction : HarvestItemFunctionBase { }

    [Function("harvestItem")]
    public class HarvestItemFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_upc", 1)]
        public virtual BigInteger Upc { get; set; }
        [Parameter("address", "_originFarmerID", 2)]
        public virtual string OriginFarmerID { get; set; }
        [Parameter("string", "_originFarmName", 3)]
        public virtual string OriginFarmName { get; set; }
        [Parameter("string", "_originFarmInformation", 4)]
        public virtual string OriginFarmInformation { get; set; }
        [Parameter("string", "_originFarmLatitude", 5)]
        public virtual string OriginFarmLatitude { get; set; }
        [Parameter("string", "_originFarmLongitude", 6)]
        public virtual string OriginFarmLongitude { get; set; }
        [Parameter("string", "_productNotes", 7)]
        public virtual string ProductNotes { get; set; }
    }

    public partial class IsConsumerFunction : IsConsumerFunctionBase { }

    [Function("isConsumer", "bool")]
    public class IsConsumerFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class IsDistributorFunction : IsDistributorFunctionBase { }

    [Function("isDistributor", "bool")]
    public class IsDistributorFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class IsFarmerFunction : IsFarmerFunctionBase { }

    [Function("isFarmer", "bool")]
    public class IsFarmerFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class IsRetailerFunction : IsRetailerFunctionBase { }

    [Function("isRetailer", "bool")]
    public class IsRetailerFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class KillFunction : KillFunctionBase { }

    [Function("kill")]
    public class KillFunctionBase : FunctionMessage
    {

    }

    public partial class PackItemFunction : PackItemFunctionBase { }

    [Function("packItem")]
    public class PackItemFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_upc", 1)]
        public virtual BigInteger Upc { get; set; }
    }

    public partial class ProcessItemFunction : ProcessItemFunctionBase { }

    [Function("processItem")]
    public class ProcessItemFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_upc", 1)]
        public virtual BigInteger Upc { get; set; }
    }

    public partial class PurchaseItemFunction : PurchaseItemFunctionBase { }

    [Function("purchaseItem")]
    public class PurchaseItemFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_upc", 1)]
        public virtual BigInteger Upc { get; set; }
    }

    public partial class ReceiveItemFunction : ReceiveItemFunctionBase { }

    [Function("receiveItem")]
    public class ReceiveItemFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_upc", 1)]
        public virtual BigInteger Upc { get; set; }
    }

    public partial class RenounceConsumerFunction : RenounceConsumerFunctionBase { }

    [Function("renounceConsumer")]
    public class RenounceConsumerFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceDistributorFunction : RenounceDistributorFunctionBase { }

    [Function("renounceDistributor")]
    public class RenounceDistributorFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceFarmerFunction : RenounceFarmerFunctionBase { }

    [Function("renounceFarmer")]
    public class RenounceFarmerFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceRetailerFunction : RenounceRetailerFunctionBase { }

    [Function("renounceRetailer")]
    public class RenounceRetailerFunctionBase : FunctionMessage
    {

    }

    public partial class SellItemFunction : SellItemFunctionBase { }

    [Function("sellItem")]
    public class SellItemFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_upc", 1)]
        public virtual BigInteger Upc { get; set; }
        [Parameter("uint256", "_price", 2)]
        public virtual BigInteger Price { get; set; }
    }

    public partial class ShipItemFunction : ShipItemFunctionBase { }

    [Function("shipItem")]
    public class ShipItemFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_upc", 1)]
        public virtual BigInteger Upc { get; set; }
    }

    public partial class FarmerAddedEventDTO : FarmerAddedEventDTOBase { }

    [Event("FarmerAdded")]
    public class FarmerAddedEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, true )]
        public virtual string Account { get; set; }
    }

    public partial class FarmerRemovedEventDTO : FarmerRemovedEventDTOBase { }

    [Event("FarmerRemoved")]
    public class FarmerRemovedEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, true )]
        public virtual string Account { get; set; }
    }

    public partial class ForSaleEventDTO : ForSaleEventDTOBase { }

    [Event("ForSale")]
    public class ForSaleEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "upc", 1, false )]
        public virtual BigInteger Upc { get; set; }
    }

    public partial class HarvestedEventDTO : HarvestedEventDTOBase { }

    [Event("Harvested")]
    public class HarvestedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "upc", 1, false )]
        public virtual BigInteger Upc { get; set; }
    }

    public partial class PackedEventDTO : PackedEventDTOBase { }

    [Event("Packed")]
    public class PackedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "upc", 1, false )]
        public virtual BigInteger Upc { get; set; }
    }

    public partial class ProcessedEventDTO : ProcessedEventDTOBase { }

    [Event("Processed")]
    public class ProcessedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "upc", 1, false )]
        public virtual BigInteger Upc { get; set; }
    }

    public partial class PurchasedEventDTO : PurchasedEventDTOBase { }

    [Event("Purchased")]
    public class PurchasedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "upc", 1, false )]
        public virtual BigInteger Upc { get; set; }
    }

    public partial class ReceivedEventDTO : ReceivedEventDTOBase { }

    [Event("Received")]
    public class ReceivedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "upc", 1, false )]
        public virtual BigInteger Upc { get; set; }
    }

    public partial class ShippedEventDTO : ShippedEventDTOBase { }

    [Event("Shipped")]
    public class ShippedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "upc", 1, false )]
        public virtual BigInteger Upc { get; set; }
    }

    public partial class SoldEventDTO : SoldEventDTOBase { }

    [Event("Sold")]
    public class SoldEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "upc", 1, false )]
        public virtual BigInteger Upc { get; set; }
    }











    public partial class FetchItemBufferOneOutputDTO : FetchItemBufferOneOutputDTOBase { }

    [FunctionOutput]
    public class FetchItemBufferOneOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "itemSKU", 1)]
        public virtual BigInteger ItemSKU { get; set; }
        [Parameter("uint256", "itemUPC", 2)]
        public virtual BigInteger ItemUPC { get; set; }
        [Parameter("address", "ownerID", 3)]
        public virtual string OwnerID { get; set; }
        [Parameter("address", "originFarmerID", 4)]
        public virtual string OriginFarmerID { get; set; }
        [Parameter("string", "originFarmName", 5)]
        public virtual string OriginFarmName { get; set; }
        [Parameter("string", "originFarmInformation", 6)]
        public virtual string OriginFarmInformation { get; set; }
        [Parameter("string", "originFarmLatitude", 7)]
        public virtual string OriginFarmLatitude { get; set; }
        [Parameter("string", "originFarmLongitude", 8)]
        public virtual string OriginFarmLongitude { get; set; }
    }

    public partial class FetchItemBufferTwoOutputDTO : FetchItemBufferTwoOutputDTOBase { }

    [FunctionOutput]
    public class FetchItemBufferTwoOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "itemSKU", 1)]
        public virtual BigInteger ItemSKU { get; set; }
        [Parameter("uint256", "itemUPC", 2)]
        public virtual BigInteger ItemUPC { get; set; }
        [Parameter("uint256", "productID", 3)]
        public virtual BigInteger ProductID { get; set; }
        [Parameter("string", "productNotes", 4)]
        public virtual string ProductNotes { get; set; }
        [Parameter("uint256", "productPrice", 5)]
        public virtual BigInteger ProductPrice { get; set; }
        [Parameter("uint256", "itemState", 6)]
        public virtual BigInteger ItemState { get; set; }
        [Parameter("address", "distributorID", 7)]
        public virtual string DistributorID { get; set; }
        [Parameter("address", "retailerID", 8)]
        public virtual string RetailerID { get; set; }
        [Parameter("address", "consumerID", 9)]
        public virtual string ConsumerID { get; set; }
    }



    public partial class IsConsumerOutputDTO : IsConsumerOutputDTOBase { }

    [FunctionOutput]
    public class IsConsumerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsDistributorOutputDTO : IsDistributorOutputDTOBase { }

    [FunctionOutput]
    public class IsDistributorOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsFarmerOutputDTO : IsFarmerOutputDTOBase { }

    [FunctionOutput]
    public class IsFarmerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsRetailerOutputDTO : IsRetailerOutputDTOBase { }

    [FunctionOutput]
    public class IsRetailerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }






















}
