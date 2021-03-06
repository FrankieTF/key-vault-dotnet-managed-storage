﻿using System;
using System.Configuration;
using System.Threading.Tasks;

namespace AzureKeyVaultManagedStorageSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // run managed storage account samples
            // MSAK management 
            Console.WriteLine("\n\n** Running storage account management sample..");
            Task.Run(() => KeyVaultManagedStorageSamples.DemonstrateStorageAccountManagementAsync())
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();

            // SAS management and usage
            Console.WriteLine("\n\n** Running SAS definition sample..");
            Task.Run(() => KeyVaultManagedStorageSamples.DemonstrateSASManagementAndUsageAsync())
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
        }
    }
}
