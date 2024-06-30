# Deploying App Service By Using Azure CLI
Azure CLI is a powerful tool that allows you to manage Azure resources directly from the command line. In this guide, we will walk through the steps to deploy an App Service on Azure, including creating an App Service plan and deploying a Web App.

> [!NOTE]
> To use the following commands, you must install Azure CLI. More information [here](https://learn.microsoft.com/en-us/cli/azure/).

## Create App Service Plan
Using this command, we will create an App Service plan, which will allow us to deploy multiple applications using App Services.

> [!NOTE]
> For more details on creating an App Service plan, refer to the [Microsoft Learn documentation on creating an Azure App Service plan](https://learn.microsoft.com/en-us/azure/app-service/overview-hosting-plans).

```sh
az appservice plan create -g jjpuente -n webplan --sku B1
```

### Flags:
- `-g jjpuente` or `--resource-group jjpuente`: Specifies the name of the resource group in which the App Service plan will be created.
- `-n webplan` or `--name webplan`: Specifies the name of the App Service plan to be created.
- `--sku B1`: Specifies the pricing tier for the App Service plan. `B1` represents the Basic pricing tier.

## Create App Service
Using this command, we will create a web application with App Services, utilizing the App Service Plan we created in the previous step.

> [!NOTE]
> For more details on creating a web application with Azure CLI, refer to the [Microsoft Learn documentation on Azure App Service](https://learn.microsoft.com/en-us/azure/app-service/).

```sh
az webapp up -g jjpuente -p webplan -n webapi -r "dotnet:8" --logs
```

### Flags:
- `-g jjpuente` or `--resource-group jjpuente`: Specifies the name of the resource group in which the Web App will be created.
- `-p webplan` or `--plan webplan`: Specifies the name of the App Service plan to use.
- `-n webapi` or `--name webapi`: Specifies the name of the Web App to be created.
- `-r "dotnet:8"` or `--runtime "dotnet:8"`: Specifies the runtime stack for the Web App. In this case, it is .NET version 8.
- `--logs`: Enables logging for the deployment process.

## Create App Service with Plan
Using this command, we will create a Web Application using App Services and also an App Service Plan, all in one step.

> [!NOTE]
> For more details on creating a web application with Azure CLI, refer to the [Microsoft Learn documentation on Azure App Service](https://learn.microsoft.com/en-us/azure/app-service/).

```sh
az webapp up -g jjpuente -n webapi-allinone -r "dotnet:8" --sku B1 --logs
```

### Flags:
- `-g jjpuente` or `--resource-group jjpuente`: Specifies the name of the resource group in which the Web App will be created.
- `-n webapi-allinone` or `--name webapi-allinone`: Specifies the name of the Web App to be created.
- `-r "dotnet:8"` or `--runtime "dotnet:8"`: Specifies the runtime stack for the Web App. In this case, it is .NET version 8.
- `--sku B1`: Specifies the pricing tier for the App Service plan that will be created and used for the Web App. `B1` represents the Basic pricing tier.
- `--logs`: Enables logging for the deployment process.

---

Return to [README](../README.md)