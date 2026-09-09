using packageCalculator.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PackageManager.Tests.TestData
{
    public class ExampleDataService : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {
            foreach (var package in LoadExampleCubicPackages())
            {
                yield return new object[] { package.Package, package.ExpectedPrice };
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private static IEnumerable<CubicPackageCase> LoadExampleCubicPackages()
        {
            var basePath = AppContext.BaseDirectory;

            var filePath = Path.Combine(AppContext.BaseDirectory, "TestData", "package_example_data.json");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' was not found.");
            }
            ;

            var jsonData = File.ReadAllText(filePath);
            var packages = System.Text.Json.JsonSerializer.Deserialize<List<CubicPackageCase>>
                (jsonData, new System.Text.Json.JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            return packages ?? new List<CubicPackageCase>();
        }

        private class CubicPackageCase
        {
            //Basic real package
            public CubicPackage Package { get; set; }

            //Expected for testing
            public int ExpectedPrice { get; set; }
        }
    }
}
