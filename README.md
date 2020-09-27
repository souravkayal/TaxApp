# TaxApp </br>
Sample Tax application for real state tax calculation.  </br>

Logic : </br>
Application will load static data in bootstrap. Currently data is populated for Copenhagen city. It will query the in memory database and find the appropriate tax information for the city. The tax calculation is fully dynamic and extensible in design. the solution is scalable and extensible as the is DI and de-couple architecture adhare in plan.  


Assumption :  </br>
1. Bulk upload feature is not implemented due to time constrant  </br>
2. All scenerio in Unit test has not covered. Few example are given to cover the basic requirement. </br>


Deployment : The app is deployed in my personal dev ops portl  </br> and deployed in personal azure subscription.
CI pipeline - https://dev.azure.com/azlearnsourav2020/TaxApp/_build </br>
CD pipeline - https://dev.azure.com/azlearnsourav2020/TaxApp/_release?_a=releases&view=mine&definitionId=1  </br>
Swagger url - https://mytaxapp.azurewebsites.net/swagger/index.html  </br>
 

Sample CURL request. </br>
curl -X POST "https://mytaxapp.azurewebsites.net/api/Tax/GetTax" -H "accept: */*" -H "Content-Type: application/json" -d "{\"municipalityName\":\"Copenhagen\",\"date\":\"2016-01-01\"}"

