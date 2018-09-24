using System;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			Dataset ds = new Dataset();
			string[] lastNames = { "Cooper", "Yen", "Kumar", "Sekar", "Reddy", "Nair", "Malik", "Cage",
								"Khan", "Samuel", "Joseph", "Ganesh", "Rao", "Menon", "Duval", "Varma",
								"King", "Xao", "Abimanyu", "Dharma", "Sharma", "Patel", "Saxena" };

			string[] maleFirstNames = { "Rufus", "Bear", "Dakota", "Fido", "Ajith", "Temujin", "Raj", "Victor", "Viran", "Yuvraj", "Verendar", "Vijil", "Aditya",
										"Vanya", "Samuel", "Koani", "Volodya", "Rami", "Veer", "Mithun", "Parmesh","Xander", "Elliot", "Abilash", "Krishna",
										"Prince", "Yiska", "Arjun", "Vinoth", "Ganesh", "Selva", "Karthik", "Jai", "Irfan", "Shami", "Nirmal", "Naveen", "Vivek",
										"Yashwendar", "Karan", "Yudrish", "Rana", "Badri", "Bupesh", "Vinay", "Tarun", "Bharath", "Laxman", "Kamal", "Ram",
										"Naresh", "Sarvan", "Chandresh", "Vignesh", "Mayank"};

			string[] femaleFirstNames = { "Maggie", "Penny", "Saya", "Princess", "Shalini", "Deepika", "Anjali", "Amritha",
								  "Abby", "Laila", "Sadie", "Olivia", "Bea", "Kavita", "Anisha", "Aishwarya", "Sana", "Kriti",
								  "Starlight", "Talla", "Isha", "Sonal", "Portia", "Arthy", "Neha", "Gayathri", "Vanya", "Kavya" };

			string[] city = { "Chennai", "Chennai", "Chennai", "Chennai", "Chennai", "Bangalore", "Bangalore", "Bangalore", "Bangalore",
							"Hyderabad", "Hyderabad", "Hyderabad", "Hyderabad", "Hyderabad", "Hyderabad",
							"Pune", "Noida", "Kolkata", "Pune", "Pune", "Kolkata" };

			string[] currentRoles = { "Developer", "Developer", "Developer", "Developer", "Developer", "Developer", "Developer", "Developer", "Developer", "Developer",
								"Analyst", "Analyst", "Analyst", "Analyst", "Analyst", "Analyst", "Analyst",
								"Architect", "Manager", "Manager", "Manager", "Manager", "Consultant", "Consultant" };

			string[] developerRoles = { "Analyst" };
			string[] analystRoles = { "Developer", "Architect" };
			string[] architectRoles = { "Analyst", "Manager" };
			string[] managerRoles = { "Architect", "Consultant" };
			string[] consultantRoles = { "Architect", "Manager" };

			string[] developerDesignation = { "Programmer Trainee", "Programmer", "Associate" };
			string[] analystDesignation = { "Associate", "Senior Associate" };
			string[] architectDesignation = { "Senior Associate", "Manager" };
			string[] managerDesignation = { "Manager", "Senior Manager" };
			string[] consultantDesignation = { "Manager", "Senior Manager" };

			string[] chennaiAddress = { "A1, Serene Flats, T Nagar", "44, Gandhi Street, CR Circle", "5, Link Road, Broadway", "52, 2nd Street, K Nagar",
										"97, Pillayarkoyil Street, Broadway", "112, 8th Cross Street, Anna Nagar", "112, 8th Cross Street, Anna Nagar",
										"22, 7th Cross Street, Anna Nagar", "99, 5th MainRoad, Perambur", "44, 12th MainRoad, Perambur",
										"88, Corporation Road, Perungudi", "91, Kamarajar Street, Triplicane", "102, Kambar Street, Sowcarpet"};

			string[] bangaloreAddress = { "11, NGEF Premises, Old Madras Road", "2, ESID Bldg. Sirur Park Road,Seshadripuram", "108, 7th Cross, Goutham Nagar",
										"99, 7th Cross, Srirampuram", "145/A, Bommasandra Indl. Area, Hosur Main Road", "No.8, Apprentice Road, HAL Colony",
										"14th Cross, IV Phase, Peenya Industrial Area", "14, North Anjaneya Temple Street, Basavanagudi",
										"No.92, 6th Main Road, Peenya" , "22, Bommasandra Indl. Area, Hosur Main Road", "12, 5th main, Vijay Nagar",
										"14, 15th Main Rd, 3rd Stage, Rajajinagar"};

			string[] hyderabadAddress = { "578 - A, Road Number 7,Banjara Hills", "44, 3rd Streer, Banjara Hills", "99, 2nd Cross Street Jubilee Hills",
										"22, Road 36, Jubilee Hills", "12, Pearl Flats, Miyapur", "22, Shivaji Street, Madinaguda",
										"12, George Road, Madinaguda", "99, Electronic Street, Ameerpet", "21, Electronic Street, Ameerpet",
										"8, Road No 2, Hitec City Layout, Madhapur", "7, Road No 7, Hitec City, Madhapur",
										"4Th Floor, Naspur House, Main Road, Himayat Nagar", "25, 3Rd Street, Durga Nagar", "51, Ram Street, Dilshuk Nagar",
										"124, Donthanapally Street, Shankarapalli", "89, Nathan Street, Miyapur", "34, Rao Street, Madinaguda",
										"18, 12 Sector, Hitec City Layout, Madhapur", "17, 5th Sector, Hitec City, Madhapur"};

			string[] puneAddress = { "1, Tanaji Chowk, Near Shivaji Maharaj Statue, Kothrud", "Renuka Nivas, Sr. No.143/1, Vishwashanti Colony",
									"11, Karishma Society Near Sangam Press, Kothrud", "21, Kedar Street, Kalyani Nagar", "88, Gandhi Street, AK Nagar",
									"28 Mantri House, Fergusson Collage Road, Shivaji Nagar", "31 Mantri House, Fergusson Collage Road, Shivaji Nagar",
									"26, Shivaji Road, St.Thomas Nagar", "27, Gaitonde Street, Ganesh Nagar", "87, BHEL Colony, Sharma Nagar",
									"A-15, MIDC Park, Talawade", "28C, MIDC Park, Talawade", "8th Floor, Amar Avinash, Bund Garden Road"};

			string[] noidaAddress = { "A-14, Eco Towers, Sector 125", "14, 12th Crorss Street, Sector 63", "Plot No 3A, Sector 126",
									"13A, 2nd MainRoad ,Sector 16", "22C, 8nd MainRoad ,Sector 99", "A-22, Eden Flats, 2nd Street, Sector 22"};

			string[] kolkataAddress = { "1, Near Burrabazar Police Station, Sambhu Mullick Lane, Burrabazar",
									"19/1/1/4, Near Satyanarayan Temple, Mukhram Kanoria Road","2 Kapalitola Lane, Bow Bazar",
									"P1, Dobson Lane, Opposite Digha Bus Stand", "133, Acharya Jagdish Chandra Bose Road",
									"11-B, Chowringhee Lane", "14, Bishnupur North 24, Pargana Diamond Harbour Road" };
			int[] rating = { 1, 2, 2, 3, 3, 3, 3, 4, 4, 5 };
			int[] salary = { 1, 2, 3, 3, 3, 3, 4, 4, 4, 5 };
			string[] genderFlag = { "M", "M", "M", "F", "F" };

			string[] improvementIdeas = { "Implement modern communication and collaboration tools",
										"Recognize and reward valuable contributions",
										"Give Employees A Virtual Suggestion Box",
										"To solve a problem: give employees an anonymous virtual suggestion box.",
										"Employees need a way to instantly connect with one another.",
										"Cultivate strong coworker relationships, schedule time for it, develop your interpersonal skills, show your appreciation, and be positive.",
										"Embrace and inspire employee autonomy",
										"Need more flexibility",
										"Provide laptop to work from home",
										"Need work from home",
										"Promote a team atmosphere more",
										"Provide rewards and coupons for encoguring the employees",
										"Need certification vouchers for exams",
										"Give helpful, timely feedback is a benefit to everyone. You can reward good behaviors and results as they occur, encouraging more of the same.",
										"Build an outstanding company culture",
										"Promote from within, Allow lateral moves",
										"Encourage employees to learn new things and develop their skills",
										"Hire a motivational speaker to work his or her magic on your employees a few times a year.",
										"Provide more weekend or fun activities",
										"Arrange for team outing and lunch",
										"Need more salary hike",
										"Please provide higher incentives",
										"Emphasize more work-life balance",
										"Hold a daily, 10-minute company meeting",
										};

			for (int i = 1; i <= 5; i++)
			{
				ds = new Dataset();
				int index = 0;

				index = rnd.Next(0, genderFlag.Length);
				ds.Gender = genderFlag[index];

				Console.Write("EmpID:");
				ds.EmpID = rnd.Next(100, 99999);
				Console.WriteLine(ds.EmpID);

				Console.Write("LastName:");
				index = rnd.Next(0, lastNames.Length);
				ds.LastName = lastNames[index];
				Console.WriteLine(ds.LastName);

				Console.Write("FirstName:");
				if (ds.Gender == "M")
				{
					index = rnd.Next(0, maleFirstNames.Length);
					ds.FirstName = maleFirstNames[index];
					Console.WriteLine(ds.FirstName);
				}
				else
				{
					index = rnd.Next(0, femaleFirstNames.Length);
					ds.FirstName = femaleFirstNames[index];
					Console.WriteLine(ds.FirstName);
				}

				Console.Write("Gender:");
				Console.WriteLine(ds.Gender);

				Console.Write("CurrentRole:");
				ds.CurrentRole = rnd.Next(0, 1);
				Console.WriteLine(ds.CurrentRole);

				index = rnd.Next(0, currentRoles.Length);
				string tempRole = currentRoles[index];

				Console.Write("DesiredRole:");
				if (ds.CurrentRole == 0)
				{
					index = rnd.Next(0, currentRoles.Length);
					ds.DesiredRole = currentRoles[index];

					switch (tempRole)
					{
						case "Developer":
							index = rnd.Next(0, developerRoles.Length);
							ds.DesiredRole = developerRoles[index];
							break;
						case "Analyst":
							index = rnd.Next(0, analystRoles.Length);
							ds.DesiredRole = analystRoles[index];
							break;
						case "Architect":
							index = rnd.Next(0, architectRoles.Length);
							ds.DesiredRole = architectRoles[index];
							break;
						case "Manager":
							index = rnd.Next(0, managerRoles.Length);
							ds.DesiredRole = managerRoles[index];
							break;
						case "Consultant":
							index = rnd.Next(0, consultantRoles.Length);
							ds.DesiredRole = consultantRoles[index];
							break;
					}
				}
				else
				{
					ds.DesiredRole = "";
				}
				Console.WriteLine(ds.DesiredRole);

				Console.Write("Designation:");
				switch (tempRole)
				{
					case "Developer":
						index = rnd.Next(0, developerDesignation.Length);
						ds.Designation = developerDesignation[index];
						break;
					case "Analyst":
						index = rnd.Next(0, analystDesignation.Length);
						ds.Designation = analystDesignation[index];
						break;
					case "Architect":
						index = rnd.Next(0, architectDesignation.Length);
						ds.Designation = architectDesignation[index];
						break;
					case "Manager":
						index = rnd.Next(0, managerDesignation.Length);
						ds.Designation = managerDesignation[index];
						break;
					case "Consultant":
						index = rnd.Next(0, consultantDesignation.Length);
						ds.Designation = consultantDesignation[index];
						break;
				}
				Console.WriteLine(ds.Designation);
				Console.Write("City:");
				index = rnd.Next(0, city.Length);
				ds.City = city[index];
				Console.WriteLine(ds.City);

				switch (ds.City)
				{
					case "Chennai":
						{
							int value = rnd.Next(150);
							string text = value.ToString("000");
							ds.Pincode = Convert.ToInt32("600" + text);

							index = rnd.Next(0, chennaiAddress.Length);
							ds.Address = chennaiAddress[index];

							break;
						}
					case "Bangalore":
						{
							int value = rnd.Next(50);
							string text = value.ToString("000");
							ds.Pincode = Convert.ToInt32("560" + text);

							index = rnd.Next(0, bangaloreAddress.Length);
							ds.Address = bangaloreAddress[index];

							break;
						}
					case "Hyderabad":
						{
							int value = rnd.Next(150);
							string text = value.ToString("000");
							ds.Pincode = Convert.ToInt32("500" + text);

							index = rnd.Next(0, hyderabadAddress.Length);
							ds.Address = hyderabadAddress[index];

							break;
						}
					case "Pune":
						{
							int value = rnd.Next(150);
							string text = value.ToString("000");
							ds.Pincode = Convert.ToInt32("411" + text);

							index = rnd.Next(0, puneAddress.Length);
							ds.Address = puneAddress[index];

							break;
						}
					case "Noida":
						{
							int value = rnd.Next(300);
							string text = value.ToString("000");
							ds.Pincode = Convert.ToInt32("201" + text);

							index = rnd.Next(0, noidaAddress.Length);
							ds.Address = noidaAddress[index];

							break;
						}
					case "Kolkata":
						{
							int value = rnd.Next(150);
							string text = value.ToString("000");
							ds.Pincode = Convert.ToInt32("700" + text);

							index = rnd.Next(0, kolkataAddress.Length);
							ds.Address = kolkataAddress[index];

							break;
						}
				}
				Console.Write("Pincode:");
				Console.WriteLine(ds.Pincode);
				Console.Write("Address:");
				Console.WriteLine(ds.Address);

				Console.Write("Email:");
				ds.Email = ds.FirstName + "." + ds.LastName + "@cognizant.com";
				Console.WriteLine(ds.Email);

				switch (tempRole)
				{
					case "Developer":
						index = rnd.Next(21 * 365, 28 * 365);
						ds.DOB = DateTime.Now.AddDays(-index);
						index = rnd.Next(1 * 365, 7 * 365);
						ds.DOJ = DateTime.Now.AddDays(-index);
						break;
					case "Analyst":
						index = rnd.Next(25 * 365, 35 * 365);
						ds.DOB = DateTime.Now.AddDays(-index);
						index = rnd.Next(1 * 365, 14 * 365);
						ds.DOJ = DateTime.Now.AddDays(-index);
						break;
					case "Architect":
						index = rnd.Next(35 * 365, 50 * 365);
						ds.DOB = DateTime.Now.AddDays(-index);
						index = rnd.Next(1 * 365, 29 * 365);
						ds.DOJ = DateTime.Now.AddDays(-index);
						break;
					case "Manager":
						index = rnd.Next(35 * 365, 50 * 365);
						ds.DOB = DateTime.Now.AddDays(-index);
						index = rnd.Next(1 * 365, 29 * 365);
						ds.DOJ = DateTime.Now.AddDays(-index);
						break;
					case "Consultant":
						index = rnd.Next(35 * 365, 50 * 365);
						ds.DOB = DateTime.Now.AddDays(-index);
						index = rnd.Next(1 * 365, 29 * 365);
						ds.DOJ = DateTime.Now.AddDays(-index);
						break;
				}
				Console.Write("DOB:");
				Console.WriteLine(ds.DOB);
				Console.Write("DOJ:");
				Console.WriteLine(ds.DOJ);

				Console.Write("YearOfAppraisal:");
				ds.YearOfAppraisal = "2017";
				Console.WriteLine(ds.YearOfAppraisal);

				Console.Write("Rating:");
				index = rnd.Next(0, rating.Length);
				ds.Rating = rating[index];
				Console.WriteLine(ds.Rating);

				Console.Write("Salary:");
				index = rnd.Next(0, salary.Length);
				ds.Salary = salary[index];
				Console.WriteLine(ds.Salary);

				Console.Write("WorkLifeBalance:");
				ds.WorkLifeBalance = rnd.Next(1, 5);
				Console.WriteLine(ds.WorkLifeBalance);

				Console.Write("CurrentLocation:");
				ds.CurrentLocation = rnd.Next(0, 1);
				Console.WriteLine(ds.CurrentLocation);

				Console.Write("PreferredLocation:");
				if (ds.CurrentLocation == 0)
				{
					index = rnd.Next(0, city.Length);
					ds.PreferredLocation = city[index];
				}
				else
				{
					ds.PreferredLocation = "";
				}
				Console.WriteLine(ds.PreferredLocation);

				Console.Write("Appraisal:");
				ds.Appraisal = rnd.Next(0, 1);
				if (ds.Rating == 5)
					ds.Appraisal = 1;
				Console.WriteLine(ds.Appraisal);

				Console.Write("Recommend:");
				ds.Recommend = rnd.Next(0, 1);
				Console.WriteLine(ds.Recommend);

				Console.Write("Opportunities:");
				ds.Opportunities = rnd.Next(0, 1);
				Console.WriteLine(ds.Opportunities);

				Console.Write("ImprovementIdea:");
				if (rnd.Next(1, 5) == 1)
				{
					index = rnd.Next(0, improvementIdeas.Length);
					ds.ImprovementIdea = improvementIdeas[index];
				}
				else
				{
					ds.ImprovementIdea = "NA";
				}
				Console.WriteLine(ds.ImprovementIdea);
				
				Console.Write("Favorite:");
				ds.Favorite = "NA";
				Console.WriteLine(ds.Favorite);
				//Favorite varchar(255) NOT NULL,

				Console.Write("Infrastructure:");
				ds.Infrastructure = rnd.Next(1, 5);
				Console.WriteLine(ds.Infrastructure);

				if ((ds.Appraisal == 0 && ds.Salary < 4) || (ds.Appraisal == 0 && ds.WorkLifeBalance < 4) || (ds.Salary < 4 && ds.WorkLifeBalance < 4))
				{
					ds.Reason = "Resigned";
				}
				else if (ds.Rating < 3 && (tempRole == "Architect" || tempRole == "Manager" || tempRole == "Consultant"))
				{
					ds.Reason = "Fired";
				}
				else
				{
					ds.Reason = "";
				}

				if (ds.Reason != "")
				{
					Console.Write("Reason:");
					Console.WriteLine(ds.Reason);
					Console.Write("DOR:");
					index = rnd.Next(30, 207);
					ds.DOR = DateTime.Now.AddDays(-index);
					Console.WriteLine(ds.DOR);
				}
				else
				{
					ds.DOR = DateTime.Now.AddYears(1);
				}

				Console.WriteLine();
			}

			Console.WriteLine("End");
		}
	}
}

