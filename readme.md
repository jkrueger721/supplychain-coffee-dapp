## Supply Chain Project
This DAPP is for a decentralized approach for supplychain.    


Find on [Etherscan](https://rinkeby.etherscan.io/address/0xa6f9d3db65fc266caa7cfa75041c08ba78b1facc)   
 
 **contract address: 0x62D937827830121003B2AA2a4AfbD090Ed6F83B2**

 **tx hash: 0xd31c2d3099f61c5a2afdd1e6a85abae2e11287f2bd3a52c2d5e9ea1bf2761745**

 ---
 ### Third Party Libraries used

 truffle-hdwallet-provider
  
  ---

  ## Instructions
  
Please make sure you've already installed ganache-cli, Truffle and enabled MetaMask extension in your browser.

### Clone project
` git clone https://github.com/jkrueger721/supplychain-coffee-dapp.git`

`cd supplychain-coffee-dapp`

Once in project directory  
`npm install`

`ganache-cli`

In a separate terminal window, test the DApp:  
(you may want to use an older version of node like 11.19.0 to run tests)  
`truffle compile`  
`truffle migrate`  
`truffle test`  
In a separate terminal window, launch the DApp:  
`cd src`  
`npm run dev`  
### Deployment  
Deploy to Rinkeby network:  
`compile`  
`truffle migrate --reset --network rinkeby`



