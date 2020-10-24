using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using Project6.Contracts.SupplyChain.ContractDefinition;

namespace Project6.Contracts.SupplyChain
{
    public partial class SupplyChainService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, SupplyChainDeployment supplyChainDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<SupplyChainDeployment>().SendRequestAndWaitForReceiptAsync(supplyChainDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, SupplyChainDeployment supplyChainDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<SupplyChainDeployment>().SendRequestAsync(supplyChainDeployment);
        }

        public static async Task<SupplyChainService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, SupplyChainDeployment supplyChainDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, supplyChainDeployment, cancellationTokenSource);
            return new SupplyChainService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public SupplyChainService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> AddConsumerRequestAsync(AddConsumerFunction addConsumerFunction)
        {
             return ContractHandler.SendRequestAsync(addConsumerFunction);
        }

        public Task<TransactionReceipt> AddConsumerRequestAndWaitForReceiptAsync(AddConsumerFunction addConsumerFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addConsumerFunction, cancellationToken);
        }

        public Task<string> AddConsumerRequestAsync(string account)
        {
            var addConsumerFunction = new AddConsumerFunction();
                addConsumerFunction.Account = account;
            
             return ContractHandler.SendRequestAsync(addConsumerFunction);
        }

        public Task<TransactionReceipt> AddConsumerRequestAndWaitForReceiptAsync(string account, CancellationTokenSource cancellationToken = null)
        {
            var addConsumerFunction = new AddConsumerFunction();
                addConsumerFunction.Account = account;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addConsumerFunction, cancellationToken);
        }

        public Task<string> AddDistributorRequestAsync(AddDistributorFunction addDistributorFunction)
        {
             return ContractHandler.SendRequestAsync(addDistributorFunction);
        }

        public Task<TransactionReceipt> AddDistributorRequestAndWaitForReceiptAsync(AddDistributorFunction addDistributorFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addDistributorFunction, cancellationToken);
        }

        public Task<string> AddDistributorRequestAsync(string account)
        {
            var addDistributorFunction = new AddDistributorFunction();
                addDistributorFunction.Account = account;
            
             return ContractHandler.SendRequestAsync(addDistributorFunction);
        }

        public Task<TransactionReceipt> AddDistributorRequestAndWaitForReceiptAsync(string account, CancellationTokenSource cancellationToken = null)
        {
            var addDistributorFunction = new AddDistributorFunction();
                addDistributorFunction.Account = account;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addDistributorFunction, cancellationToken);
        }

        public Task<string> AddFarmerRequestAsync(AddFarmerFunction addFarmerFunction)
        {
             return ContractHandler.SendRequestAsync(addFarmerFunction);
        }

        public Task<TransactionReceipt> AddFarmerRequestAndWaitForReceiptAsync(AddFarmerFunction addFarmerFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addFarmerFunction, cancellationToken);
        }

        public Task<string> AddFarmerRequestAsync(string account)
        {
            var addFarmerFunction = new AddFarmerFunction();
                addFarmerFunction.Account = account;
            
             return ContractHandler.SendRequestAsync(addFarmerFunction);
        }

        public Task<TransactionReceipt> AddFarmerRequestAndWaitForReceiptAsync(string account, CancellationTokenSource cancellationToken = null)
        {
            var addFarmerFunction = new AddFarmerFunction();
                addFarmerFunction.Account = account;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addFarmerFunction, cancellationToken);
        }

        public Task<string> AddRetailerRequestAsync(AddRetailerFunction addRetailerFunction)
        {
             return ContractHandler.SendRequestAsync(addRetailerFunction);
        }

        public Task<TransactionReceipt> AddRetailerRequestAndWaitForReceiptAsync(AddRetailerFunction addRetailerFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addRetailerFunction, cancellationToken);
        }

        public Task<string> AddRetailerRequestAsync(string account)
        {
            var addRetailerFunction = new AddRetailerFunction();
                addRetailerFunction.Account = account;
            
             return ContractHandler.SendRequestAsync(addRetailerFunction);
        }

        public Task<TransactionReceipt> AddRetailerRequestAndWaitForReceiptAsync(string account, CancellationTokenSource cancellationToken = null)
        {
            var addRetailerFunction = new AddRetailerFunction();
                addRetailerFunction.Account = account;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addRetailerFunction, cancellationToken);
        }

        public Task<string> BuyItemRequestAsync(BuyItemFunction buyItemFunction)
        {
             return ContractHandler.SendRequestAsync(buyItemFunction);
        }

        public Task<TransactionReceipt> BuyItemRequestAndWaitForReceiptAsync(BuyItemFunction buyItemFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(buyItemFunction, cancellationToken);
        }

        public Task<string> BuyItemRequestAsync(BigInteger upc)
        {
            var buyItemFunction = new BuyItemFunction();
                buyItemFunction.Upc = upc;
            
             return ContractHandler.SendRequestAsync(buyItemFunction);
        }

        public Task<TransactionReceipt> BuyItemRequestAndWaitForReceiptAsync(BigInteger upc, CancellationTokenSource cancellationToken = null)
        {
            var buyItemFunction = new BuyItemFunction();
                buyItemFunction.Upc = upc;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(buyItemFunction, cancellationToken);
        }

        public Task<FetchItemBufferOneOutputDTO> FetchItemBufferOneQueryAsync(FetchItemBufferOneFunction fetchItemBufferOneFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<FetchItemBufferOneFunction, FetchItemBufferOneOutputDTO>(fetchItemBufferOneFunction, blockParameter);
        }

        public Task<FetchItemBufferOneOutputDTO> FetchItemBufferOneQueryAsync(BigInteger upc, BlockParameter blockParameter = null)
        {
            var fetchItemBufferOneFunction = new FetchItemBufferOneFunction();
                fetchItemBufferOneFunction.Upc = upc;
            
            return ContractHandler.QueryDeserializingToObjectAsync<FetchItemBufferOneFunction, FetchItemBufferOneOutputDTO>(fetchItemBufferOneFunction, blockParameter);
        }

        public Task<FetchItemBufferTwoOutputDTO> FetchItemBufferTwoQueryAsync(FetchItemBufferTwoFunction fetchItemBufferTwoFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<FetchItemBufferTwoFunction, FetchItemBufferTwoOutputDTO>(fetchItemBufferTwoFunction, blockParameter);
        }

        public Task<FetchItemBufferTwoOutputDTO> FetchItemBufferTwoQueryAsync(BigInteger upc, BlockParameter blockParameter = null)
        {
            var fetchItemBufferTwoFunction = new FetchItemBufferTwoFunction();
                fetchItemBufferTwoFunction.Upc = upc;
            
            return ContractHandler.QueryDeserializingToObjectAsync<FetchItemBufferTwoFunction, FetchItemBufferTwoOutputDTO>(fetchItemBufferTwoFunction, blockParameter);
        }

        public Task<string> HarvestItemRequestAsync(HarvestItemFunction harvestItemFunction)
        {
             return ContractHandler.SendRequestAsync(harvestItemFunction);
        }

        public Task<TransactionReceipt> HarvestItemRequestAndWaitForReceiptAsync(HarvestItemFunction harvestItemFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(harvestItemFunction, cancellationToken);
        }

        public Task<string> HarvestItemRequestAsync(BigInteger upc, string originFarmerID, string originFarmName, string originFarmInformation, string originFarmLatitude, string originFarmLongitude, string productNotes)
        {
            var harvestItemFunction = new HarvestItemFunction();
                harvestItemFunction.Upc = upc;
                harvestItemFunction.OriginFarmerID = originFarmerID;
                harvestItemFunction.OriginFarmName = originFarmName;
                harvestItemFunction.OriginFarmInformation = originFarmInformation;
                harvestItemFunction.OriginFarmLatitude = originFarmLatitude;
                harvestItemFunction.OriginFarmLongitude = originFarmLongitude;
                harvestItemFunction.ProductNotes = productNotes;
            
             return ContractHandler.SendRequestAsync(harvestItemFunction);
        }

        public Task<TransactionReceipt> HarvestItemRequestAndWaitForReceiptAsync(BigInteger upc, string originFarmerID, string originFarmName, string originFarmInformation, string originFarmLatitude, string originFarmLongitude, string productNotes, CancellationTokenSource cancellationToken = null)
        {
            var harvestItemFunction = new HarvestItemFunction();
                harvestItemFunction.Upc = upc;
                harvestItemFunction.OriginFarmerID = originFarmerID;
                harvestItemFunction.OriginFarmName = originFarmName;
                harvestItemFunction.OriginFarmInformation = originFarmInformation;
                harvestItemFunction.OriginFarmLatitude = originFarmLatitude;
                harvestItemFunction.OriginFarmLongitude = originFarmLongitude;
                harvestItemFunction.ProductNotes = productNotes;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(harvestItemFunction, cancellationToken);
        }

        public Task<bool> IsConsumerQueryAsync(IsConsumerFunction isConsumerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsConsumerFunction, bool>(isConsumerFunction, blockParameter);
        }

        
        public Task<bool> IsConsumerQueryAsync(string account, BlockParameter blockParameter = null)
        {
            var isConsumerFunction = new IsConsumerFunction();
                isConsumerFunction.Account = account;
            
            return ContractHandler.QueryAsync<IsConsumerFunction, bool>(isConsumerFunction, blockParameter);
        }

        public Task<bool> IsDistributorQueryAsync(IsDistributorFunction isDistributorFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsDistributorFunction, bool>(isDistributorFunction, blockParameter);
        }

        
        public Task<bool> IsDistributorQueryAsync(string account, BlockParameter blockParameter = null)
        {
            var isDistributorFunction = new IsDistributorFunction();
                isDistributorFunction.Account = account;
            
            return ContractHandler.QueryAsync<IsDistributorFunction, bool>(isDistributorFunction, blockParameter);
        }

        public Task<bool> IsFarmerQueryAsync(IsFarmerFunction isFarmerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsFarmerFunction, bool>(isFarmerFunction, blockParameter);
        }

        
        public Task<bool> IsFarmerQueryAsync(string account, BlockParameter blockParameter = null)
        {
            var isFarmerFunction = new IsFarmerFunction();
                isFarmerFunction.Account = account;
            
            return ContractHandler.QueryAsync<IsFarmerFunction, bool>(isFarmerFunction, blockParameter);
        }

        public Task<bool> IsRetailerQueryAsync(IsRetailerFunction isRetailerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsRetailerFunction, bool>(isRetailerFunction, blockParameter);
        }

        
        public Task<bool> IsRetailerQueryAsync(string account, BlockParameter blockParameter = null)
        {
            var isRetailerFunction = new IsRetailerFunction();
                isRetailerFunction.Account = account;
            
            return ContractHandler.QueryAsync<IsRetailerFunction, bool>(isRetailerFunction, blockParameter);
        }

        public Task<string> KillRequestAsync(KillFunction killFunction)
        {
             return ContractHandler.SendRequestAsync(killFunction);
        }

        public Task<string> KillRequestAsync()
        {
             return ContractHandler.SendRequestAsync<KillFunction>();
        }

        public Task<TransactionReceipt> KillRequestAndWaitForReceiptAsync(KillFunction killFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(killFunction, cancellationToken);
        }

        public Task<TransactionReceipt> KillRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<KillFunction>(null, cancellationToken);
        }

        public Task<string> PackItemRequestAsync(PackItemFunction packItemFunction)
        {
             return ContractHandler.SendRequestAsync(packItemFunction);
        }

        public Task<TransactionReceipt> PackItemRequestAndWaitForReceiptAsync(PackItemFunction packItemFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(packItemFunction, cancellationToken);
        }

        public Task<string> PackItemRequestAsync(BigInteger upc)
        {
            var packItemFunction = new PackItemFunction();
                packItemFunction.Upc = upc;
            
             return ContractHandler.SendRequestAsync(packItemFunction);
        }

        public Task<TransactionReceipt> PackItemRequestAndWaitForReceiptAsync(BigInteger upc, CancellationTokenSource cancellationToken = null)
        {
            var packItemFunction = new PackItemFunction();
                packItemFunction.Upc = upc;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(packItemFunction, cancellationToken);
        }

        public Task<string> ProcessItemRequestAsync(ProcessItemFunction processItemFunction)
        {
             return ContractHandler.SendRequestAsync(processItemFunction);
        }

        public Task<TransactionReceipt> ProcessItemRequestAndWaitForReceiptAsync(ProcessItemFunction processItemFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(processItemFunction, cancellationToken);
        }

        public Task<string> ProcessItemRequestAsync(BigInteger upc)
        {
            var processItemFunction = new ProcessItemFunction();
                processItemFunction.Upc = upc;
            
             return ContractHandler.SendRequestAsync(processItemFunction);
        }

        public Task<TransactionReceipt> ProcessItemRequestAndWaitForReceiptAsync(BigInteger upc, CancellationTokenSource cancellationToken = null)
        {
            var processItemFunction = new ProcessItemFunction();
                processItemFunction.Upc = upc;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(processItemFunction, cancellationToken);
        }

        public Task<string> PurchaseItemRequestAsync(PurchaseItemFunction purchaseItemFunction)
        {
             return ContractHandler.SendRequestAsync(purchaseItemFunction);
        }

        public Task<TransactionReceipt> PurchaseItemRequestAndWaitForReceiptAsync(PurchaseItemFunction purchaseItemFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(purchaseItemFunction, cancellationToken);
        }

        public Task<string> PurchaseItemRequestAsync(BigInteger upc)
        {
            var purchaseItemFunction = new PurchaseItemFunction();
                purchaseItemFunction.Upc = upc;
            
             return ContractHandler.SendRequestAsync(purchaseItemFunction);
        }

        public Task<TransactionReceipt> PurchaseItemRequestAndWaitForReceiptAsync(BigInteger upc, CancellationTokenSource cancellationToken = null)
        {
            var purchaseItemFunction = new PurchaseItemFunction();
                purchaseItemFunction.Upc = upc;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(purchaseItemFunction, cancellationToken);
        }

        public Task<string> ReceiveItemRequestAsync(ReceiveItemFunction receiveItemFunction)
        {
             return ContractHandler.SendRequestAsync(receiveItemFunction);
        }

        public Task<TransactionReceipt> ReceiveItemRequestAndWaitForReceiptAsync(ReceiveItemFunction receiveItemFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(receiveItemFunction, cancellationToken);
        }

        public Task<string> ReceiveItemRequestAsync(BigInteger upc)
        {
            var receiveItemFunction = new ReceiveItemFunction();
                receiveItemFunction.Upc = upc;
            
             return ContractHandler.SendRequestAsync(receiveItemFunction);
        }

        public Task<TransactionReceipt> ReceiveItemRequestAndWaitForReceiptAsync(BigInteger upc, CancellationTokenSource cancellationToken = null)
        {
            var receiveItemFunction = new ReceiveItemFunction();
                receiveItemFunction.Upc = upc;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(receiveItemFunction, cancellationToken);
        }

        public Task<string> RenounceConsumerRequestAsync(RenounceConsumerFunction renounceConsumerFunction)
        {
             return ContractHandler.SendRequestAsync(renounceConsumerFunction);
        }

        public Task<string> RenounceConsumerRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RenounceConsumerFunction>();
        }

        public Task<TransactionReceipt> RenounceConsumerRequestAndWaitForReceiptAsync(RenounceConsumerFunction renounceConsumerFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceConsumerFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RenounceConsumerRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RenounceConsumerFunction>(null, cancellationToken);
        }

        public Task<string> RenounceDistributorRequestAsync(RenounceDistributorFunction renounceDistributorFunction)
        {
             return ContractHandler.SendRequestAsync(renounceDistributorFunction);
        }

        public Task<string> RenounceDistributorRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RenounceDistributorFunction>();
        }

        public Task<TransactionReceipt> RenounceDistributorRequestAndWaitForReceiptAsync(RenounceDistributorFunction renounceDistributorFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceDistributorFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RenounceDistributorRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RenounceDistributorFunction>(null, cancellationToken);
        }

        public Task<string> RenounceFarmerRequestAsync(RenounceFarmerFunction renounceFarmerFunction)
        {
             return ContractHandler.SendRequestAsync(renounceFarmerFunction);
        }

        public Task<string> RenounceFarmerRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RenounceFarmerFunction>();
        }

        public Task<TransactionReceipt> RenounceFarmerRequestAndWaitForReceiptAsync(RenounceFarmerFunction renounceFarmerFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceFarmerFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RenounceFarmerRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RenounceFarmerFunction>(null, cancellationToken);
        }

        public Task<string> RenounceRetailerRequestAsync(RenounceRetailerFunction renounceRetailerFunction)
        {
             return ContractHandler.SendRequestAsync(renounceRetailerFunction);
        }

        public Task<string> RenounceRetailerRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RenounceRetailerFunction>();
        }

        public Task<TransactionReceipt> RenounceRetailerRequestAndWaitForReceiptAsync(RenounceRetailerFunction renounceRetailerFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceRetailerFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RenounceRetailerRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RenounceRetailerFunction>(null, cancellationToken);
        }

        public Task<string> SellItemRequestAsync(SellItemFunction sellItemFunction)
        {
             return ContractHandler.SendRequestAsync(sellItemFunction);
        }

        public Task<TransactionReceipt> SellItemRequestAndWaitForReceiptAsync(SellItemFunction sellItemFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(sellItemFunction, cancellationToken);
        }

        public Task<string> SellItemRequestAsync(BigInteger upc, BigInteger price)
        {
            var sellItemFunction = new SellItemFunction();
                sellItemFunction.Upc = upc;
                sellItemFunction.Price = price;
            
             return ContractHandler.SendRequestAsync(sellItemFunction);
        }

        public Task<TransactionReceipt> SellItemRequestAndWaitForReceiptAsync(BigInteger upc, BigInteger price, CancellationTokenSource cancellationToken = null)
        {
            var sellItemFunction = new SellItemFunction();
                sellItemFunction.Upc = upc;
                sellItemFunction.Price = price;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(sellItemFunction, cancellationToken);
        }

        public Task<string> ShipItemRequestAsync(ShipItemFunction shipItemFunction)
        {
             return ContractHandler.SendRequestAsync(shipItemFunction);
        }

        public Task<TransactionReceipt> ShipItemRequestAndWaitForReceiptAsync(ShipItemFunction shipItemFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(shipItemFunction, cancellationToken);
        }

        public Task<string> ShipItemRequestAsync(BigInteger upc)
        {
            var shipItemFunction = new ShipItemFunction();
                shipItemFunction.Upc = upc;
            
             return ContractHandler.SendRequestAsync(shipItemFunction);
        }

        public Task<TransactionReceipt> ShipItemRequestAndWaitForReceiptAsync(BigInteger upc, CancellationTokenSource cancellationToken = null)
        {
            var shipItemFunction = new ShipItemFunction();
                shipItemFunction.Upc = upc;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(shipItemFunction, cancellationToken);
        }
    }
}
