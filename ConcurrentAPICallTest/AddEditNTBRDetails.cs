using RestSharp;

namespace ConcurrentAPICallTest
{
    public class AddEditNTBRDetails
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<string> crsIds = new List<string>()
            {
                "VSHP00000001"
                ,"VSHP00000002"
                ,"VSHP00000003"
                ,"VSHP00000004"
            };

            List<string> ntbIds = new List<string>()
            {
                "VSHP00000041"
                ,"VSHP00000046"
                ,"VSHP00000047"
                ,"VSHP00000048"
                ,"VSHP00000049"
                ,"VSHP00000050"
                ,"VSHP00000051"
                ,"VSHP00000052"
            };


            var crews = Enumerable.Empty<object>().Select(x => new
            {
                CrewId = (string?)null,
                SetId = (string?)null
            }).ToList();

            crews.Add(new
            {
                CrewId = (string?)"ODES00019437",
                SetId = (string?)"CHEN00003437"
            });

            crews.Add(new
            {
                CrewId = (string?)"GLAS00036495",
                SetId = (string?)"CHEN00047440"
            });

            crews.Add(new
            {
                CrewId = (string?)"CHEN00003279",
                SetId = (string?)"CHEN00057468"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044167",
                SetId = (string?)"D90200510226"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044168",
                SetId = (string?)"D90200510246"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044169",
                SetId = (string?)"D90200510247"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044171",
                SetId = (string?)"D90200510255"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044172",
                SetId = (string?)"D90200510285"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044175",
                SetId = (string?)"D90200510428"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044177",
                SetId = (string?)"D90200510429"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044183",
                SetId = (string?)"D90200510446"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044184",
                SetId = (string?)"D90200510454"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044185",
                SetId = (string?)"D90200510462"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044186",
                SetId = (string?)"D90200510524"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044187",
                SetId = (string?)"D90200510594"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044191",
                SetId = (string?)"D90200510758"
            });

            crews.Add(new
            {
                CrewId = (string?)"GLAS00009024",
                SetId = (string?)"D90200510806"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044196",
                SetId = (string?)"D90200511064"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044197",
                SetId = (string?)"D90200511219"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044198",
                SetId = (string?)"D90200511229"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044199",
                SetId = (string?)"D90200511231"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044200",
                SetId = (string?)"D90200511233"
            });

            crews.Add(new
            {
                CrewId = (string?)"D90200044201",
                SetId = (string?)"D90200511234"
            });

            int crsCount = crsIds.Count;
            int ntbCount = ntbIds.Count;

            var requests = Enumerable.Empty<object>().Select(x => new
            {
                Request = (RestRequest?)null,
                Client = (RestClient?)null,
            }).ToList();

            int count = 0;

            bool useDevPointing = true;

            string hostAdd = useDevPointing ? "DevSSCrewingApi.v.group" : "localhost:7004";

            foreach (var crw in crews)
            {
                var request = new RestRequest($"https://{hostAdd}/api/V1/CrewingAPI/AddEditNTBRDetails", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vVlNoaXAvU2hpcFN1cmUvQ2xpZW50SUQiOlsiNWQ2MmM2YTUxMjQ2NGY3ZjkzMGY5NmUwODBkZmNiMjMiLCI1ZDYyYzZhNTEyNDY0ZjdmOTMwZjk2ZTA4MGRmY2IyMyJdLCJ1bmlxdWVfbmFtZSI6InNheXNhdyIsImh0dHA6Ly9WU2hpcC9TaGlwU3VyZS9Vc2VySUQiOiJWR1JQMDAwMDQxMjciLCJodHRwOi8vVlNoaXAvU2hpcFN1cmUvU2l0ZUlEIjoiU1lTVDAwMDAwMDAxIiwiaHR0cDovL1ZTaGlwL1NoaXBTdXJlL0RlcGFydG1lbnRJRCI6IkFDQ1QiLCJodHRwOi8vVlNoaXAvU2hpcFN1cmUvVXNlckRpc3BsYXlOYW1lIjoiU2F5YWxpIFNhd2FudCIsImh0dHA6Ly9WU2hpcC9TaGlwU3VyZS9Vc2VyRW1haWwiOiJzYXlhbGkuc2F3YW50QHZzaGlwcy5jb20iLCJodHRwOi8vVlNoaXAvU2hpcFN1cmUvU2hpcFN1cmVSb2xlIjpbIntcIlJvbGVJZFwiOlwiQ01DQTAwMDAwMDAxXCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIk1ETSBWYWxpZGF0b3JcIixcIklzUHJpbWFyeVwiOnRydWV9Iiwie1wiUm9sZUlkXCI6XCJDTUNBMDAwMDAwMDJcIixcIlJvbGVEZXNjcmlwdGlvblwiOlwiTURNIFNNRSBBcHByb3ZlclwiLFwiSXNQcmltYXJ5XCI6ZmFsc2V9Iiwie1wiUm9sZUlkXCI6XCJDTUNBMDAwMDAwMDNcIixcIlJvbGVEZXNjcmlwdGlvblwiOlwiTURNIFNpZ24gT2ZmXCIsXCJJc1ByaW1hcnlcIjpmYWxzZX0iLCJ7XCJSb2xlSWRcIjpcIkNNQ0EwMDAwMDAwNFwiLFwiUm9sZURlc2NyaXB0aW9uXCI6XCJNRE0gLSBDb25maWd1cmF0aW9uXCIsXCJJc1ByaW1hcnlcIjpmYWxzZX0iLCJ7XCJSb2xlSWRcIjpcIkNNQ0EwMDAwMDAwNVwiLFwiUm9sZURlc2NyaXB0aW9uXCI6XCJNRE0gLSBQU1VQUCBTaWduIE9mZlwiLFwiSXNQcmltYXJ5XCI6ZmFsc2V9Iiwie1wiUm9sZUlkXCI6XCJDTUNBMDAwMDAwMDZcIixcIlJvbGVEZXNjcmlwdGlvblwiOlwiTURNIC0gRW50aXR5IEEgU2lnbiBPZmZcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiQ01DQTAwMDAwMDA3XCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIk1ETSAtIEVudGl0eSBCIFNpZ24gT2ZmXCIsXCJJc1ByaW1hcnlcIjpmYWxzZX0iLCJ7XCJSb2xlSWRcIjpcIkNNQ0EwMDAwMDAwOFwiLFwiUm9sZURlc2NyaXB0aW9uXCI6XCJNRE0gLSBFbnRpdHkgQyBTaWduIE9mZlwiLFwiSXNQcmltYXJ5XCI6ZmFsc2V9Iiwie1wiUm9sZUlkXCI6XCJDTUNBMDAwMDAwMDlcIixcIlJvbGVEZXNjcmlwdGlvblwiOlwiTURNIC0gRW50aXR5IEQgU2lnbiBPZmZcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiQ01DQTAwMDAwMDEwXCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIk1ETSAtIEVudGl0eSBFIFNpZ24gT2ZmXCIsXCJJc1ByaW1hcnlcIjpmYWxzZX0iLCJ7XCJSb2xlSWRcIjpcIkNNQ0EwMDAwMDAxMVwiLFwiUm9sZURlc2NyaXB0aW9uXCI6XCJNRE0gLSBFbnRpdHkgRiBTaWduIE9mZlwiLFwiSXNQcmltYXJ5XCI6ZmFsc2V9Iiwie1wiUm9sZUlkXCI6XCJDTUNBMDAwMDAwMTJcIixcIlJvbGVEZXNjcmlwdGlvblwiOlwiTURNIC0gRW50aXR5IEcgU2lnbiBPZmZcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiQ01DQTAwMDAwMDEzXCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIk1ETSAtIEVudGl0eSBIIFNpZ24gT2ZmXCIsXCJJc1ByaW1hcnlcIjpmYWxzZX0iLCJ7XCJSb2xlSWRcIjpcIkNNQ0EwMDAwMDAxNFwiLFwiUm9sZURlc2NyaXB0aW9uXCI6XCJNRE0gLSBFbnRpdHkgMSBTaWduIE9mZlwiLFwiSXNQcmltYXJ5XCI6ZmFsc2V9Iiwie1wiUm9sZUlkXCI6XCJDTUNBMDAwMDAwMTVcIixcIlJvbGVEZXNjcmlwdGlvblwiOlwiTURNIC0gRW50aXR5IDIgU2lnbiBPZmZcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiQ01DQTAwMDAwMDE2XCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIk1ETSAtIEVudGl0eSAzIFNpZ24gT2ZmXCIsXCJJc1ByaW1hcnlcIjpmYWxzZX0iLCJ7XCJSb2xlSWRcIjpcIkNNQ0EwMDAwMDAxN1wiLFwiUm9sZURlc2NyaXB0aW9uXCI6XCJNRE0gLSBFbnRpdHkgNCBTaWduIE9mZlwiLFwiSXNQcmltYXJ5XCI6ZmFsc2V9Iiwie1wiUm9sZUlkXCI6XCJDTUNBMDAwMDAwMThcIixcIlJvbGVEZXNjcmlwdGlvblwiOlwiTURNIC0gRW50aXR5IDUgU2lnbiBPZmZcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiQ01DQTAwMDAwMDE5XCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIk1ETSAtIEVudGl0eSA2IFNpZ24gT2ZmXCIsXCJJc1ByaW1hcnlcIjpmYWxzZX0iLCJ7XCJSb2xlSWRcIjpcIkNNQ0EwMDAwMDAyMFwiLFwiUm9sZURlc2NyaXB0aW9uXCI6XCJNRE0gLSBFbnRpdHkgNyBTaWduIE9mZlwiLFwiSXNQcmltYXJ5XCI6ZmFsc2V9Iiwie1wiUm9sZUlkXCI6XCJDTUNBMDAwMDAwMjFcIixcIlJvbGVEZXNjcmlwdGlvblwiOlwiTURNIC0gRW50aXR5IDggU2lnbiBPZmZcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiQ01DQTAwMDAwMDIyXCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIk1ETSAtIEVudGl0eSA5IFNpZ24gT2ZmXCIsXCJJc1ByaW1hcnlcIjpmYWxzZX0iLCJ7XCJSb2xlSWRcIjpcIkNNQ0EwMDAwMDAyM1wiLFwiUm9sZURlc2NyaXB0aW9uXCI6XCJNRE0gLSBFbnRpdHkgMTAgU2lnbiBPZmZcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiQ01DQTAwMDAwMDI0XCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIk1ETSAtIEVudGl0eSAxMSBTaWduIE9mZlwiLFwiSXNQcmltYXJ5XCI6ZmFsc2V9Iiwie1wiUm9sZUlkXCI6XCJDTUNBMDAwMDAwMjVcIixcIlJvbGVEZXNjcmlwdGlvblwiOlwiTURNIC0gRW50aXR5IDEyIFNpZ24gT2ZmXCIsXCJJc1ByaW1hcnlcIjpmYWxzZX0iLCJ7XCJSb2xlSWRcIjpcIkNNQ0EwMDAwMDAyNlwiLFwiUm9sZURlc2NyaXB0aW9uXCI6XCJNRE0gLSBFbnRpdHkgMTMgU2lnbiBPZmZcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiQ01DQTAwMDAwMDI3XCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIk1ETSAtIEVudGl0eSAxNCBTaWduIE9mZlwiLFwiSXNQcmltYXJ5XCI6ZmFsc2V9Iiwie1wiUm9sZUlkXCI6XCJDTUNBMDAwMDAwMjhcIixcIlJvbGVEZXNjcmlwdGlvblwiOlwiTURNIC0gRW50aXR5IDE1IFNpZ24gT2ZmXCIsXCJJc1ByaW1hcnlcIjpmYWxzZX0iLCJ7XCJSb2xlSWRcIjpcIkNNQ0EwMDAwMDAyOVwiLFwiUm9sZURlc2NyaXB0aW9uXCI6XCJNRE0gLSBFbnRpdHkgMTYgU2lnbiBPZmZcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiQ01DQTAwMDAwMDMwXCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIk1ETSAtIEVudGl0eSAxNyBTaWduIE9mZlwiLFwiSXNQcmltYXJ5XCI6ZmFsc2V9Iiwie1wiUm9sZUlkXCI6XCJDTUNBMDAwMDAwMzFcIixcIlJvbGVEZXNjcmlwdGlvblwiOlwiTURNIC0gRW50aXR5IDE4IFNpZ24gT2ZmXCIsXCJJc1ByaW1hcnlcIjpmYWxzZX0iLCJ7XCJSb2xlSWRcIjpcIkNNQ0EwMDAwMDAzMlwiLFwiUm9sZURlc2NyaXB0aW9uXCI6XCJNRE0gLSBFbnRpdHkgMTkgU2lnbiBPZmZcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiQ01DQTAwMDAwMDMzXCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIk1ETSAtIEVudGl0eSAyMCBTaWduIE9mZlwiLFwiSXNQcmltYXJ5XCI6ZmFsc2V9Iiwie1wiUm9sZUlkXCI6XCJDUlJBMDAwMDAwMDFcIixcIlJvbGVEZXNjcmlwdGlvblwiOlwiTWFzdGVyIFBsYW5uZXJcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiRDkwMjAwMDAxNDI4XCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIkNyZXdPbmJvYXJkaW5nXCIsXCJJc1ByaW1hcnlcIjpmYWxzZX0iLCJ7XCJSb2xlSWRcIjpcIkZOUkEwMDAwMDAwM1wiLFwiUm9sZURlc2NyaXB0aW9uXCI6XCJTYWxlcyBJbnZvaWNlIExldmVsIDFcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiR0xBUzAwMDAwMDEyXCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIkluZm9ybWF0aW9uIFN5c3RlbXMgRGVwYXJ0bWVudFwiLFwiSXNQcmltYXJ5XCI6ZmFsc2V9Iiwie1wiUm9sZUlkXCI6XCJHTEFTMDAwMDAwMjBcIixcIlJvbGVEZXNjcmlwdGlvblwiOlwiQ3JldyBBc3Npc3RhbnRcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiR0xBUzAwMDAwMDIxXCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIkNyZXcgQ01QXCIsXCJJc1ByaW1hcnlcIjpmYWxzZX0iLCJ7XCJSb2xlSWRcIjpcIkdMQVMwMDAwMDAyMlwiLFwiUm9sZURlc2NyaXB0aW9uXCI6XCJDcmV3IE1hbmFnZXJcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiR0xBUzAwMDAwMDM2XCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIkNoaWVmIEVuZ2luZWVyXCIsXCJJc1ByaW1hcnlcIjpmYWxzZX0iLCJ7XCJSb2xlSWRcIjpcIkdMQVMwMDAwMDAzN1wiLFwiUm9sZURlc2NyaXB0aW9uXCI6XCIybmQgRW5naW5lZXIgVGVzdFwiLFwiSXNQcmltYXJ5XCI6ZmFsc2V9Iiwie1wiUm9sZUlkXCI6XCJHTEFTMDAwMDAwNDlcIixcIlJvbGVEZXNjcmlwdGlvblwiOlwiQ3Jld09uYm9hcmRpbmdcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiR0xBUzAwMDAwMTA0XCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIkNyZXcgQWRtaW5cIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiR0xBUzAwMDAwMTQ1XCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIlBsYW5uaW5nIE1hbmFnZXJcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiSEVDSDAwMDAwMDAyXCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIk1ETSBPcGVyYXRvclwiLFwiSXNQcmltYXJ5XCI6ZmFsc2V9Iiwie1wiUm9sZUlkXCI6XCJNUlJBMDAwMDAwMDFcIixcIlJvbGVEZXNjcmlwdGlvblwiOlwiU3VwZXIgQWRtaW5cIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiUFVNQTAwMDAwMDAzXCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIk1ETSBDb21wYW55IE1haW50YWluZXJcIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiVkdSUDAwMDAwMDYwXCIsXCJSb2xlRGVzY3JpcHRpb25cIjpcIlRpbWUgQW5kIEF0dGVuZGFuY2UgQWRtaW5cIixcIklzUHJpbWFyeVwiOmZhbHNlfSIsIntcIlJvbGVJZFwiOlwiLTFcIixcIlJvbGVEZXNjcmlwdGlvblwiOlwiQXBpVGVzdFJvbGVcIixcIklzUHJpbWFyeVwiOmZhbHNlfSJdLCJuYmYiOjE2NjgwMDAzNDksImV4cCI6MTY2ODAzNzU0OSwiaWF0IjoxNjY4MDAwMzQ5LCJpc3MiOiJWU2hpcHNUb2tlbkFwaSIsImF1ZCI6IlZTaGlwc1Jlc291cmNlQXBpIn0.OfOQXhbGBJjrJBx2V7fOt8wfG2gZFyw6auGT5PwOdgo");
                var body = string.Format(@"{{"
                + "\n   \"NTNId\": null,"
                + "\n   \"CrewId\": \"{0}\","
                + "\n   \"EmployeeStatusId\": \"{1}\","
                + "\n   \"EventStatusId\": \"{2}\","
                + "\n   \"ServiceId\": \"{3}\","
                + "\n   \"InitiatedById\": \"VGRP00004127\","
                + "\n   \"InitiatedOn\": \"{5}\","
                + "\n   \"Notes\": \"test{4}\""
                + "\n}}", crw.CrewId, crsIds[rnd.Next(crsCount)], ntbIds[rnd.Next(ntbCount)], crw.SetId, ++count, DateTime.UtcNow);

                request.AddParameter("application/json", body, ParameterType.RequestBody);

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