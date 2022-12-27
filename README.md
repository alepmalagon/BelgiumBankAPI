# BelgiumBankAPI
## ASP.NET MVC OpenAPI for Managing Bank Accounts

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

## Features

- Autocreates one Costumer John Doe (Id = 1)
- Publishes a swagger client to access endpoints
 
## Endpoints

- [POST] ​/api​/BankAccounts​/CreateEditAccount
- [GET] ​/api​/BankAccounts​/GetAccount
- [GET] ​/api​/BankAccounts​/GetCostumerAccount
- [GET] ​/api​/BankAccounts​/GetCostumerTransactions
- [GET] ​/api​/BankAccounts​/GetAllCostumers

## Docker

BelgiumBankAPI is very easy to install and deploy in a Docker container.

Get docker image from https://hub.docker.com/repository/registry-1.docker.io/alepmalagon/dot_net/general

By default, the Docker will expose port 61768.
