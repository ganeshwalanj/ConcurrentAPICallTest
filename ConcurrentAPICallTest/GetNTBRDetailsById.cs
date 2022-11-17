using RestSharp;

namespace ConcurrentAPICallTest
{
    public class GetNTBRDetailsById
    {
        static void Main(string[] args)
        {
            var ntbrIds = new List<string>
            {
                "D90200002711","D90200002710","D90200002709","D90200002708","D90200002701","D90200002704","D90200002705","D90200002706","D90200002707","D90200002702","D90200002703","D90200002700","D90200002699","D90200002697","D90200002698","D90200002696","D90200002695","D90200002694","D90200002691","D90200002693","D90200002692","D90200002690","D90200002689","D90200002688","D90200002686"
            };

            var requests = Enumerable.Empty<object>().Select(x => new
            {
                Request = (RestRequest?)null,
                Client = (RestClient?)null,
            }).ToList();

            int count = 0;

            bool useDevPointing = true;

            string hostAdd = useDevPointing ? "DevSSCrewingApi.v.group" : "localhost:7004";

            foreach (var ntbrId in ntbrIds)
            {
                var request = new RestRequest($"https://{hostAdd}/api/V1/CrewingAPI/GetNTBRDetailsById/{ntbrId}", Method.Get);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vVlNoaXAvU2hpcFN1cmUvQ2xpZW50SUQiOlsiNWQ2MmM2YTUxMjQ2NGY3ZjkzMGY5NmUwODBkZmNiMjMiLCI1ZDYyYzZhNTEyNDY0ZjdmOTMwZjk2ZTA4MGRmY2IyMyJdLCJ1bmlxdWVfbmFtZSI6InNheXNhdyIsImh0dHA6Ly9WU2hpcC9TaGlwU3VyZS9Vc2VySUQiOiJWR1JQMDAwMDQxMjciLCJodHRwOi8vVlNoaXAvU2hpcFN1cmUvU2l0ZUlEIjoiU1lTVDAwMDAwMDAxIiwiaHR0cDovL1ZTaGlwL1NoaXBTdXJlL0RlcGFydG1lbnRJRCI6IkFDQ1QiLCJodHRwOi8vVlNoaXAvU2hpcFN1cmUvVXNlckRpc3BsYXlOYW1lIjoiU2F5YWxpIFNhd2FudCIsImh0dHA6Ly9WU2hpcC9TaGlwU3VyZS9Vc2VyRW1haWwiOiJzYXlhbGkuc2F3YW50QHZzaGlwcy5jb20iLCJodHRwOi8vVlNoaXAvU2hpcFN1cmUvU2l0ZVR5cGUiOiJNQU5PRkYiLCJodHRwOi8vVlNoaXAvU2hpcFN1cmUvQ29tcGFueSI6IlYuU2hpcHMgR2xhc2dvdyIsImh0dHA6Ly9WU2hpcC9TaGlwU3VyZS9TaGlwU3VyZVJvbGUiOiJ7XCJSb2xlSWRcIjpcIkNNQ0EwMDAwMDAwMVwiLFwiUm9sZURlc2NyaXB0aW9uXCI6XCJNRE0gVmFsaWRhdG9yXCIsXCJJc1ByaW1hcnlcIjp0cnVlfSIsIm5iZiI6MTY2ODY3ODY2MSwiZXhwIjoxNjY4NzE1ODYxLCJpYXQiOjE2Njg2Nzg2NjEsImlzcyI6IlZTaGlwc1Rva2VuQXBpIiwiYXVkIjoiVlNoaXBzUmVzb3VyY2VBcGkifQ.BaAT7NXD5QOsv4HdU5ObCVOzwnbyqfaxNcOxdlOi9Lw");

                var client = new RestClient();

                requests.Add(new { Request = (RestRequest?)request, Client = (RestClient?)client });
            }

            var responses = new List<RestResponse>();

            Parallel.ForEach(requests, req =>
            {
                var res = req.Client?.Execute(req?.Request);
                responses.Add(res);
            });

            Console.WriteLine(responses.Count);

        }
    }
}