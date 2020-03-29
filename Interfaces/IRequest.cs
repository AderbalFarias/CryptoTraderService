﻿using RestSharp;

namespace CryptoTraderService.Services
{
    public interface IRequest
    {
        string SendRequest(string host, string token, string json, Method method);
        string SendRequestMarket(string host, string token, string json, Method method);
    }
}