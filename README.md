# backend-intergation-testing-sample-db
Contains simple backend project to demonstrate integration testing capabilities. Has DB, Refit, Fluent Assertions plugged in.

# Bootstrapping Guide
...inside *Package Manager Console*
* resolve Nuget dependencies
* run `update-database` to create main DB
* run `$env:ASPNETCORE_ENVIRONMENT='Integration-Tests'` followed by `update-database` to create integration testing DB
* You are good to go with the integration tests!
