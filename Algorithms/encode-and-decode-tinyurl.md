```cs
 /**
  Problem Name : Encode and Decode TinyURL
  Problem URL : https://leetcode.com/problems/encode-and-decode-tinyurl/
  Description :
    TinyURL is a URL shortening service where you enter a URL such as https://leetcode.com/problems/design-tinyurl and it returns a short URL such as http://tinyurl.com/4e9iAk. Design a class to encode a URL and decode a tiny URL.
    There is no restriction on how your encode/decode algorithm should work. You just need to ensure that a URL can be encoded to a tiny URL and the tiny URL can be decoded to the original URL.
  Difficulty : Medium
  Language : C#
  Category : Algorithms - Hash Table
*/
public class Codec 
{
    private string alphabet = "0123456789abcdefghijklmnopqrstuvwxyz-_";
    private string tinyURL = "http://tinyurl.com/";
    // key -> URL , value -> tinyURL
    private Dictionary<string, string> urls = new Dictionary<string, string>();
    
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) 
    {
        Random rand = new Random();
        string encodedUrl = tinyURL;
        do
        {
            int i = rand.Next(0, alphabet.Length);
            encodedUrl += alphabet[i];
        }while(urls.ContainsKey(encodedUrl));
   
        urls.Add(encodedUrl, longUrl);
        return encodedUrl;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) 
    {
        if(urls.ContainsKey(shortUrl))
            return urls[shortUrl];
        return null;
    }
    
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));
```cs
