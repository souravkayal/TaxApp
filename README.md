# TaxApp
Sample Tax application for real state tax calculation. 

Assumption : 
1. Bulk upload feature is not implemented due to time constrant 
2. All scenerio in Unit test has not covered. Few example are given to cover the basic requirement.

Deployment : The app is deployed in my personal dev ops portl 
CI pipeline - https://dev.azure.com/azlearnsourav2020/TaxApp/_build
CD pipeline - https://dev.azure.com/azlearnsourav2020/TaxApp/_release?_a=releases&view=mine&definitionId=1
Swagger url - https://mytaxapp.azurewebsites.net/swagger/index.html

Sample CURL request.

curl -X POST "https://mytaxapp.azurewebsites.net/api/Tax/GetTax" -H "accept: */*" -H "Content-Type: application/json" -d "{\"municipalityName\":\"Copenhagen\",\"date\":\"2016-01-01\"}"

Feature
•	It has its own database where municipality taxes are stored
  Used In memory database with Entity framework for same
  
•	Taxes should have ability to be scheduled (yearly, monthly ,weekly ,daily) for each municipality
  User can set based on time/duration
  
Applicationshould have ability to import municipalities data from file (choose one data format you believe is suitable)
  Not implemented due to time constraint
  
•	Applicationshould have ability to insert new records for municipality taxes (one record at a time)
  Implemeted to add new tax information
  
•	User can ask for a specific municipality tax by entering municipality name and date
  Implemented 
  
•	Errors needs to be handled i.e. internal errors should not to be exposed to the end user
  Implemented global error handler 
  
•	You should ensure that application works correctly
  It's working as per expectation.
  
