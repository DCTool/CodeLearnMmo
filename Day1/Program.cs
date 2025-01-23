using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using xNet;

namespace Day1
{
    internal class Program
    {
        static string contentType = "application/x-www-form-urlencoded";
         static void apiLikePage()
        {

            // Những giá trị sẽ thay đổi khi gọi api:   cookie, token, userAgent, UID, các ID tài khoản ,fb_dtsg ,jazoest ,lsd




            // B1: Khai báo biến
            HttpRequest request = new HttpRequest();

            // B2: Gán giá trị UserAgent
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36";

            // B3: Cho phép request sử dụng Cookie
            request.Cookies = new CookieDictionary(false);

            // B4: Thêm Cookie vào request
            string cookie2 = "datr=zu8hZ9gng7DH1NvqAkQ_x5Aq; sb=zu8hZ9uavnfXDif-V3Wm2QTq; ps_l=1; ps_n=1; wl_cbv=v2%3Bclient_version%3A2663%3Btimestamp%3A1730750839; c_user=100028109628762; dpr=0.9468750357627869; fr=1xsMNZ8nj3EEEZn6h.AWU_TS2Tcju3pKgRdtTaTHokIGU.BnkpM1..AAA.0.0.BnkpM1.AWXGHQMMoMg; xs=50%3A6Aq6O38wzXKaEg%3A2%3A1734403204%3A-1%3A6348%3A%3AAcW60B6ECXFbuJ6J720INnhEEYLXEQl2Ur55o3giXoM; presence=C%7B%22t3%22%3A%5B%5D%2C%22utc3%22%3A1737660622669%2C%22v%22%3A1%7D; wd=2028x519";

            for (int i = 0; i < cookie2.Split(';').Length; i++)
            {
                try
                {
                    string name = cookie2.Split(';')[i].Split('=')[0].Trim();
                    string value = cookie2.Split(';')[i].Substring(cookie2.Split(';')[i].IndexOf('=') + 1).Trim();
                    if (request.Cookies.ContainsKey(name))
                        request.Cookies.Remove(name);
                    if (name == "useragent")
                    {
                        string useragentvia = "";
                        useragentvia = value.Trim();
                        request.UserAgent = useragentvia;


                    }
                    request.Cookies.Add(name, value);

                }
                catch (Exception exx)
                {
                }
            }

            // B5: Copy Header ( use Copy as cURL (bash) -> Choose C# RestSharp - PostMan)
            /*
             - Xoá hết dòng không bắt đầu bằng request
             - Xoá dòng chứa cookie, referer, Chromium và dòng có giá trị chuỗi rỗng ""
             - Khai báo biến toàn cục contentType và sau đó xoá dòng có chứa content-type
             - Comment dòng chứa AddParameter
             */

            request.AddHeader("accept", "*/*");
            request.AddHeader("accept-language", "en-US,en;q=0.9,vi;q=0.8");
            request.AddHeader("origin", "https://www.facebook.com");
            request.AddHeader("priority", "u=1, i");
            request.AddHeader("sec-ch-prefers-color-scheme", "light");
            request.AddHeader("sec-ch-ua-full-version-list", "\"Google Chrome\";v=\"131.0.6778.266\", \"Chromium\";v=\"131.0.6778.266\", \"Not_A Brand\";v=\"24.0.0.0\"");
            request.AddHeader("sec-ch-ua-mobile", "?0");
            request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
            request.AddHeader("sec-ch-ua-platform-version", "\"15.0.0\"");
            request.AddHeader("sec-fetch-dest", "empty");
            request.AddHeader("sec-fetch-mode", "cors");
            request.AddHeader("sec-fetch-site", "same-origin");
            request.AddHeader("x-asbd-id", "129477");
            request.AddHeader("x-fb-friendly-name", "CometProfilePlusLikeMutation");
            request.AddHeader("x-fb-lsd", "mlrUiuL0mDux5pCPG_nQ8S");
            //request.AddParameter("av", "100028109628762");
            //request.AddParameter("__aaid", "0");
            //request.AddParameter("__user", "100028109628762");
            //request.AddParameter("__a", "1");
            //request.AddParameter("__req", "12");
            //request.AddParameter("__hs", "20111.HYP:comet_pkg.2.1.0.0.1");
            //request.AddParameter("dpr", "1");
            //request.AddParameter("__ccg", "EXCELLENT");
            //request.AddParameter("__rev", "1019532684");
            //request.AddParameter("__s", "67yev6:sc782w:cawm7w");
            //request.AddParameter("__hsi", "7463202514647862982");
            //request.AddParameter("__dyn", "7xeXzWK1ixt0mUyEqxemh0noeEb8nwgUaqwh8ngS3q2ibwNwnof8boG0x8bo6u3y4o2Gwn82nwb-q7oc81EEbbwto886C11wBz83WwgEcEhwGxu782lwv89kbxS1Fwc61awkovwRwlE-U2exi4UaEW2au1jwUBwJK14xm3y11xfxmu3W3y261eBx_wHwdG7EbXCwLyESE2KwwwOg2cwMwhEkxebwHwKG4UrwFg2fwxyo566k1FwgUjwOwWzUfHDzUiwRK6E4-mEbUaUaE2Txq");
            //request.AddParameter("__csr", "gccqzgF2sQ9T7NL3AX4EAQuGlhTn9sqHvtR7GIFZ9bv5EAD5FFPRhQnkBtdEyZGBh3ZtKGjpfoHgC-AHnGhydrbSAKt9GmBVLQZdAAGQQRAlqhfWp8Chdd6-hABCAyrVQHAGQ8hpHGJ4zKF5FaiVWF5y8_gCF9paDWUOBxeVu9yAKmH8Wy9LgSeyahFvK8yucx54mt1i9xSbKVEhKHyo8EjjgnAy8Ci4Umx2Fo-m6Q2C4UiyoyA5URaVoCaKVHCx7UGi4Eymq6ogwyCiDwxxqEvy8G2HgghUy2i6oS5odo88R1q1uwj89E8EbGzoTDwiUTyE4i4U9pEfUaE13Ub81KHByQi8y62G8wkEtyUUCeAwPggxAHGfkMbE2-zE1q8twDa3-3x08O7UjwOwai6Uy0wQ1jzE2CwuTwj8foy7Uvwt8y0IU467o4S0_kqcx28ucpA0PCmqew-wg8lKEaZfoS1Jwqk58dpUy2rxrG4EO5o053Xw6xw0dyO06Pk08kwdm0jF6y4aIE2h8Eigb820g0gog4IEbo4m0km7Q0Go0Ty0m-0pp0eu2-0nq9wft03mE1qm5oq804WA0su07VE1ZP05Xw1TLw3IU3hyqw5NCw4ow2To2jwIw5Uw0yZw7ZK0tgw0Zmq08wCu");
            //request.AddParameter("__comet_req", "15");
            //request.AddParameter("fb_dtsg", "NAcNGixqTSdvvTtXYhpu_Gq_N8Qb2Tky6DN6o753A8ijdIT3dNWcKLw:50:1734403204");
            //request.AddParameter("jazoest", "25514");
            //request.AddParameter("lsd", "mlrUiuL0mDux5pCPG_nQ8S");
            //request.AddParameter("__spin_r", "1019532684");
            //request.AddParameter("__spin_b", "trunk");
            //request.AddParameter("__spin_t", "1737662245");
            //request.AddParameter("fb_api_caller_class", "RelayModern");
            //request.AddParameter("fb_api_req_friendly_name", "CometProfilePlusLikeMutation");
            //request.AddParameter("variables", "{\"input\":{\"is_tracking_encrypted\":false,\"page_id\":\"434030763116471\",\"source\":null,\"tracking\":null,\"actor_id\":\"100028109628762\",\"client_mutation_id\":\"1\"},\"scale\":1}");
            //request.AddParameter("server_timestamps", "true");
            //request.AddParameter("doc_id", "6716077648448761");



            // B6: Khai báo url gọi api
            string urlLikePage = "https://www.facebook.com/api/graphql/";

            // B7 Khai báo biến chứa form data nếu Method là POST còn GET thì bỏ qua ( Javascript XHR - PostMan )
            var data = "av=100028109628762&__aaid=0&__user=100028109628762&__a=1&__req=12&__hs=20111.HYP%3Acomet_pkg.2.1.0.0.1&dpr=1&__ccg=EXCELLENT&__rev=1019532684&__s=67yev6%3Asc782w%3Acawm7w&__hsi=7463202514647862982&__dyn=7xeXzWK1ixt0mUyEqxemh0noeEb8nwgUaqwh8ngS3q2ibwNwnof8boG0x8bo6u3y4o2Gwn82nwb-q7oc81EEbbwto886C11wBz83WwgEcEhwGxu782lwv89kbxS1Fwc61awkovwRwlE-U2exi4UaEW2au1jwUBwJK14xm3y11xfxmu3W3y261eBx_wHwdG7EbXCwLyESE2KwwwOg2cwMwhEkxebwHwKG4UrwFg2fwxyo566k1FwgUjwOwWzUfHDzUiwRK6E4-mEbUaUaE2Txq&__csr=gccqzgF2sQ9T7NL3AX4EAQuGlhTn9sqHvtR7GIFZ9bv5EAD5FFPRhQnkBtdEyZGBh3ZtKGjpfoHgC-AHnGhydrbSAKt9GmBVLQZdAAGQQRAlqhfWp8Chdd6-hABCAyrVQHAGQ8hpHGJ4zKF5FaiVWF5y8_gCF9paDWUOBxeVu9yAKmH8Wy9LgSeyahFvK8yucx54mt1i9xSbKVEhKHyo8EjjgnAy8Ci4Umx2Fo-m6Q2C4UiyoyA5URaVoCaKVHCx7UGi4Eymq6ogwyCiDwxxqEvy8G2HgghUy2i6oS5odo88R1q1uwj89E8EbGzoTDwiUTyE4i4U9pEfUaE13Ub81KHByQi8y62G8wkEtyUUCeAwPggxAHGfkMbE2-zE1q8twDa3-3x08O7UjwOwai6Uy0wQ1jzE2CwuTwj8foy7Uvwt8y0IU467o4S0_kqcx28ucpA0PCmqew-wg8lKEaZfoS1Jwqk58dpUy2rxrG4EO5o053Xw6xw0dyO06Pk08kwdm0jF6y4aIE2h8Eigb820g0gog4IEbo4m0km7Q0Go0Ty0m-0pp0eu2-0nq9wft03mE1qm5oq804WA0su07VE1ZP05Xw1TLw3IU3hyqw5NCw4ow2To2jwIw5Uw0yZw7ZK0tgw0Zmq08wCu&__comet_req=15&fb_dtsg=NAcNGixqTSdvvTtXYhpu_Gq_N8Qb2Tky6DN6o753A8ijdIT3dNWcKLw%3A50%3A1734403204&jazoest=25514&lsd=mlrUiuL0mDux5pCPG_nQ8S&__spin_r=1019532684&__spin_b=trunk&__spin_t=1737662245&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=CometProfilePlusLikeMutation&variables=%7B%22input%22%3A%7B%22is_tracking_encrypted%22%3Afalse%2C%22page_id%22%3A%22434030763116471%22%2C%22source%22%3Anull%2C%22tracking%22%3Anull%2C%22actor_id%22%3A%22100028109628762%22%2C%22client_mutation_id%22%3A%221%22%7D%2C%22scale%22%3A1%7D&server_timestamps=true&doc_id=6716077648448761";


            // B8: Call Api
            string responseData = request.Post(urlLikePage, data, contentType).ToString();

            // xử lý text mã hoá 
            responseData = System.Text.RegularExpressions.Regex.Unescape(responseData);

            // B9 Xử lý kết quả trả về 
            if (responseData.Contains("IS_SUBSCRIBED"))
            {
                Console.WriteLine("Like page thành công");
            }
            else
            {
                if (responseData.Contains("403"))
                {
                    Console.WriteLine("lỗi 403");
                }

                if (responseData.Contains("404"))
                {
                    Console.WriteLine("lỗi 404");
                }
                Console.WriteLine("like page thất bại");

            }
        }


        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            apiLikePage();


            // 
            Console.ReadKey();

        }

    }


}


