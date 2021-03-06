﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Doppler.API.Social.Chatting
{
    public class ConversationMessageContent
    {
        [Key]
        public int Id { get; set; }
        public ConversationMessage Message { get; set; }
        public string Text { get; set; }
        public List<ConversationMessageMediaContent> MediaContents { get; set; }
    }
}
