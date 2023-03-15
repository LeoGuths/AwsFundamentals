* aws s3api list-buckets
* aws lambda list-functions
* aws lambda invoke --function-name SimpleLambda --cli-binary-format raw-in-base64-out --payload '{ ""Hello"": ""From Console"" }' response.json
* Get-Content .\response.json
* dotnet tool install -g Amazon.Lambda.Tools
* dotnet new -i Amazon.Lambda.Templates
* dotnet lambda invoke-function SimpleLambda --payload '{ ""Hello"": ""From Console"" }'
* dotnet lambda deploy-function SimpleLambda2
* dotnet lambda deploy-serverless SimpleHttpLambda
* dotnet lambda delete-serverless SimpleHttpLambda
* dotnet tool install -g Amazon.Lambda.TestTool-6.0