﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Las_OchSkrivhjalp.Models {
	public class WriteWordFromImage : IQuestion {
		public int ID { get; set; }

		public string ImageSrc { get; set; }
		public string Headline { get; set; }
		public string Hint { get; set; }

		public string CorrectAnswer { get; set; }

		public Object Ask() {
			return new { ImageSrc = ImageSrc, Headline = Headline, Hint = Hint };
		}

		public Object Answer(string answer) {
			bool correct = answer.Equals(CorrectAnswer, StringComparison.OrdinalIgnoreCase);
			return new { Correct = correct, points = correct ? 1 : 0, CorrectAnswer = CorrectAnswer };
		}

		public int CategoryID { get; set; }
		public virtual QuestionCategory Category { get; set; }
	}
}