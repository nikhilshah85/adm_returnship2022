namespace apiCallsMS.Models
{
    public class PostDataModel
    {
        public int userId { get; set; }
        public int Id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        List<PostDataModel> postdata = new List<PostDataModel>();

        public List<PostDataModel> GetPostData()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();

            //clear the default from browser

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync(url);
            var result = response.Result;

            if (result.IsSuccessStatusCode)
            {
                var data = result.Content.ReadAsAsync<List<PostDataModel>>();
                data.Wait();
                postdata = data.Result;


            }
            else
            {
                throw new Exception("Could not get the data, try again later");
            }
            return postdata;

        }





    }
}
