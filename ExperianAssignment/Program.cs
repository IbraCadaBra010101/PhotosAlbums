using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExperianAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}



//.NET Developer - Coding Exercise

//Thank you for taking the time to do our technical test.  We appreciate you are doing this in your own time,
//so please do not spend too long on it. Feel free to add comments or a readme to explain how/if you saved time or what you would be doing to take this into production.
//Intro
//The Open Data Platform aggregates, understands and acts on a wide range of data. This data may come from the end user, Experian assets or external providers.
//This exercise aims to provide a simplification of part of that journey to assess the level you are working at and how you would technically fit into our team.
//Two of our developers (your future teammates) will review the solution, like a pull request. This will hopefully lead to some good discussion in your interview
//to help us understand
//your technical capabilities. Our team will have a particular focus on how you have tested your solution and how you are adhering to SOLID principles. 
//Task
//Design and create a RESTful API in ASP.NET Core. The API should call, combine, and return these 2 API endpoints into a single HTTP response.
//The response should show the combined collection so that each Album contains a collection of its Photos. (i.e. photo.albumId == album.Id)
//http://jsonplaceholder.typicode.com/photos
//http://jsonplaceholder.typicode.com/albums
//Your API should consist of 2 operations; one to return all the data from the above endpoints, and one to return data relating to a single User Id.
//The design of the endpoints and schema of your API is up to you, but you must include all the data from the provided endpoints.
//You can find documentation for the endpoints here: http://jsonplaceholder.typicode.com/guide/ 

//Requirements
//Your API should be written in C# 
//You should use either .NET Core 3.1 or .NET 5
//You may use any IDE, but you must supply a valid .sln file 
//Your solution must compile and run in a single step 
//Avoid including artefacts from your local build, e.g. NuGet packages, bin/obj folders
//You should upload your code to GitHub, or supply a download link to a ZIP file from OneDrive
//Considerations
//We'd like you imagine this a real API that will be deployed as part of a real-life application. Consider how you would handle things such as troubleshooting errors in Production, an appropriate level of testing, etc. You may use additional libraries or frameworks as needed. Your code should be high quality, but you do not need to provide an Enterprise-level implementation of every detail. You may provide a basic implementation, then add TODO comments, or notes in a README.md file, detailing how you would improve your implementation.

//We look forward to hearing from you!
//The Experian Dev Team
