﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels.Output
{
    public class PostViewModel
    {
        public long PostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime PostedOn { get; set; }
        public byte ReadTime { get; set; }
        public long NumberOfViews { get; set; }

        public string UserId { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorBiography { get; set; }
    }
}