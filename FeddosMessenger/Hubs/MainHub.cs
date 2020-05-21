﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FeddosMessenger.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using SharedTypes.SocialTypes;

namespace FeddosMessenger.Hubs
{
    [Authorize]
    public class MainHub:Hub
    {
        
        public async Task GetContacts(string pattern)
        {
            List<Contact> Contacts = await MongoDbContext.UsersCollection.AsQueryable().Where(x => x.CallName.Contains(pattern) || x.Contact.Name.Contains(pattern)).Select(x => x.Contact).ToListAsync();
            await Clients.Caller.SendAsync("ReceiveContacts", Contacts);
        }
        public override async Task OnConnectedAsync()
        {
            Console.WriteLine("Connected! " + Context.ConnectionId);
            await base.OnConnectedAsync();
        }
    }
}