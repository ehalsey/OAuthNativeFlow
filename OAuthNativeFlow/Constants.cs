namespace OAuthNativeFlow
{
    public static class Constants
    {
        public static string AppName = "OAuthNativeFlow";

        // OAuth
        // For Google login, configure at https://console.developers.google.com/
        public static string iOSClientId = "Q0mxMu0s1HmcJt7hVVF1thg2xfEBRyuIXfIVIw4JVImdvKNxjP";
        public static string AndroidClientId = "<insert Android client ID here>";

		// These values do not need changing
		public static string Scope = "com.intuit.quickbooks.accounting";
		public static string AuthorizeUrl = "https://appcenter.intuit.com/connect/oauth2";
		public static string AccessTokenUrl = "https://oauth.platform.intuit.com/oauth2/v1/tokens/bearer";
		public static string UserInfoUrl = "https://accounts.intuit.com/v1/openid_connect/userinfo";

        // Set these to reversed iOS/Android client ids, with :/oauth2redirect appended
        public static string iOSRedirectUrl = "Q0mxMu0s1HmcJt7hVVF1thg2xfEBRyuIXfIVIw4JVImdvKNxjP:/oauth2redirect";
        public static string AndroidRedirectUrl = "<insert Android redirect URL here>:/oauth2redirect";
    }
}
