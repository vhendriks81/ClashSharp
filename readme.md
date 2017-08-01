#ClashSharp

##A C# client library for the Clash of Clans API
Register for your own developer account here - https://developer.clashofclans.com/
Create your token(s) here - https://developer.clashofclans.com/#/account


##Configure Your API Access Token

Create a config file in the same location as your App.config / Web.config called `app.secrets.json`.  Put this config in the new file and set "value" to your API access token. 

```json
{
  "clashApiKey": "<insert your key here>"
}
```

Alternatively I've added an `app.secrets.config.sample` where you can update the key and rename to `app.secrets.json` and you should be good to go.

*Make sure you don't commit your token to source control!*
