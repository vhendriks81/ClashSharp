﻿namespace ClashSharp.Constants
{
    public static class UrlConstants
    {
        // may need to have a better way to deal with versioning of URLs if supercell ever updates the API.

        public const string GetClanInformationUrlTemplate = @"https://api.clashofclans.com/v1/clans/{0}";
        public const string ListClanMembersUrlTemplate = @"https://api.clashofclans.com/v1/clans/{0}/members";
        public const string SearchClansUrlTemplate = @"https://api.clashofclans.com/v1/clans{0}";
    }
}