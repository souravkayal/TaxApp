# TaxApp </br>
Sample Tax application for real state tax calculation.  </br>


Assumption :  </br>
1. Bulk upload feature is not implemented due to time constrant  </br>
2. All scenerio in Unit test has not covered. Few example are given to cover the basic requirement. </br>


Deployment : The app is deployed in my personal dev ops portl 
CI pipeline - https://dev.azure.com/azlearnsourav2020/TaxApp/_build
CD pipeline - https://dev.azure.com/azlearnsourav2020/TaxApp/_release?_a=releases&view=mine&definitionId=1
Swagger url - https://mytaxapp.azurewebsites.net/swagger/index.html


Sample CURL request. </br>
curl -X POST "https://mytaxapp.azurewebsites.net/api/Tax/GetTax" -H "accept: */*" -H "Content-Type: application/json" -d "{\"municipalityName\":\"Copenhagen\",\"date\":\"2016-01-01\"}"

