﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShortenURL.Models
{
	public class URLSModel
	{
         
	public string LongURL { get; set; }
	public string ShortURL { get; set; }

	}
}