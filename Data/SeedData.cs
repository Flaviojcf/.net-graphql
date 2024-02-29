using Domain.Models;
using TransferPay.Data.Context;

namespace Data
{
    public static class SeedData
    {
        public static void EnsureSeedData(this MyDbContext db)
        {
            if (!db.PropertyModel.Any() && db.PaymentModel.Any())
            {
                var properties = new List<PropertyModel>
                {
                    new PropertyModel
                    {
                        City = "Katowice",
                        Family = "Smith",
                        Name = "Big house",
                        Street = "Sokolska",
                        Value = 100000,
                        Payments = new List<PaymentModel>
                        {
                            new PaymentModel
                            {
                                DateCreated = new DateTime(2019, 07, 01),
                                DateOverdue = new DateTime(2019, 07, 15),
                                IsPaid = true,
                                Value = 1500
                            },
                            new PaymentModel
                            {
                                DateCreated = new DateTime(2019, 08, 01),
                                DateOverdue = new DateTime(2019, 08, 15),
                                IsPaid = true,
                                Value = 1500
                            },
                            new PaymentModel
                            {
                                DateCreated = new DateTime(2019, 09, 01),
                                DateOverdue = new DateTime(2019, 09, 15),
                                IsPaid = false,
                                Value = 1500
                            }
                        }
                    },
                    new PropertyModel
                    {
                        City = "Warszawa",
                        Family = "Nowak",
                        Name = "White house",
                        Street = "Wiejska",
                        Value = 300500,
                        Payments = new List<PaymentModel>
                        {
                            new PaymentModel
                            {
                                DateCreated = new DateTime(2019, 07, 01),
                                DateOverdue = new DateTime(2019, 07, 15),
                                IsPaid = true,
                                Value = 3000
                            },
                            new PaymentModel
                            {
                                DateCreated = new DateTime(2019, 08, 01),
                                DateOverdue = new DateTime(2019, 08, 15),
                                IsPaid = true,
                                Value = 3000
                            },
                            new PaymentModel
                            {
                                DateCreated = new DateTime(2019, 09, 01),
                                DateOverdue = new DateTime(2019, 09, 15),
                                IsPaid = false,
                                Value = 3000
                            }
                        }
                    },
                    new PropertyModel
                    {
                        City = "Gdańska",
                        Family = "Pomorscy",
                        Name = "Sea house",
                        Street = "Gdańska",
                        Value = 51000,
                        Payments = new List<PaymentModel>
                        {
                            new PaymentModel
                            {
                                DateCreated = new DateTime(2019, 07, 01),
                                DateOverdue = new DateTime(2019, 07, 15),
                                IsPaid = true,
                                Value = 800
                            },
                            new PaymentModel
                            {
                                DateCreated = new DateTime(2019, 08, 01),
                                DateOverdue = new DateTime(2019, 08, 15),
                                IsPaid = true,
                                Value = 800
                            },
                            new PaymentModel
                            {
                                DateCreated = new DateTime(2019, 09, 01),
                                DateOverdue = new DateTime(2019, 09, 15),
                                IsPaid = true,
                                Value = 800
                            }
                        }
                    }
                };

                db.PropertyModel.AddRange(properties);
                db.SaveChanges();
            }

        }
    }
}
