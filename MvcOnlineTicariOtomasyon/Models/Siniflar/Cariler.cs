﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
	public class Cariler
	{
		[Key]
		public int CariId { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(30,ErrorMessage ="En fazla 30 karakter veri girişi yapabilirsiniz.")] 
		public string CariAd { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		[Required(ErrorMessage ="Bu alanı boş geçemezsiniz!")]
		public string CariSoyad { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(13)]
		public string CariSehir { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(50)]
		public string CariMail { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(15)]
		public string CariSifre { get; set; }
		public bool Durum { get; set; }  //yeni prop ekledim.
		public ICollection<SatisHareket> SatisHarekets { get; set; }

	}
	}
