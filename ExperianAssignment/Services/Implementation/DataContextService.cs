using ExperianAssignment.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExperianAssignment.Services.Implementation
{
    public class DataContextService: IDataContextService
    {
        private readonly HttpClient client;

        public DataContextService(IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient("DataContextService");
        }

        public async Task<IEnumerable<Photo>> GetPhotos(string photos)
        {
         
            var response = await client.GetAsync(photos);
            IEnumerable<Photo> result;
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<IEnumerable<Photo>>(stringResponse);

            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }

            return result;
        }

        public async Task<IEnumerable<Album>> GetAlbums(string albums)
        { 
            var response = await client.GetAsync(albums);
            IEnumerable<Album> result;
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<IEnumerable<Album>>(stringResponse);
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }

            return result;
        }
    }
}