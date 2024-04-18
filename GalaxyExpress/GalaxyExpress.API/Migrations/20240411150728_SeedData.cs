using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalaxyExpress.API.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("011bfa78-8079-4b59-9a2b-bc6f6e829c86"), 0, new DateTime(1960, 8, 7, 20, 13, 1, 268, DateTimeKind.Local).AddTicks(8506), 551.4501999672190000m, "ef360ce0-b3df-4465-a4b3-ed0cdefee0f9", null, null, null, false, null, "Peter", "Mosciski", false, null, "Peter.Mosciski", null, null, "AQAAAAEAACcQAAAAEAV8u4gKP38W5KAZbTFcS2E/zB9AxmTC+GwkvfizlohJgkLLLiz4vAOaJfZejUQFnA==", null, false, null, null, 0, false, null },
                    { new Guid("01b6209b-4724-4a1b-8ab1-22694a2927ac"), 0, new DateTime(1942, 8, 20, 9, 26, 14, 611, DateTimeKind.Local).AddTicks(4283), 111.2037371751090000m, "3fbe72f8-a8a6-4486-8f2f-dd6839d112ce", null, null, null, false, null, "Shelly", "Dach", false, null, "Shelly.Dach20", null, null, "AQAAAAEAACcQAAAAEIKhT9SO4pFIPvT1x5I78h6oKDDml/j9YC4u40wauj2cgOAPJvYKYZwAB6ZcnCKWXw==", null, false, null, null, 1, false, null },
                    { new Guid("025318b8-b68a-4350-ad23-a79900a71bf6"), 0, null, 914.4513221477050000m, "12860f9d-13bb-4b49-9233-6692deb0b4d6", null, null, null, false, null, "Pamela", "DuBuque", false, null, "Pamela30", null, null, "AQAAAAEAACcQAAAAEJyjfkOx9fTOVyxruVUmrCztifllZxQVJJDmePiVC4QRb82V/rJ9btT7y+NijSwSjw==", null, false, null, null, 1, false, null },
                    { new Guid("03206cd0-0a83-4f1d-a4c3-c69cd723a833"), 0, new DateTime(1977, 9, 15, 3, 37, 28, 908, DateTimeKind.Local).AddTicks(3289), 747.3121265267090000m, "a2590cb4-cabd-4ae7-b8a7-2641395be44d", null, null, null, false, "Marc", "Marc", "Quitzon", false, null, "Marc.Quitzon12", null, null, "AQAAAAEAACcQAAAAEIjqb0R8EAntxHIp3klFMrrsFCmlrbjQZ2Ru9yK8RGsUyuyYD0IN1iPBrRbrvcK/4w==", null, false, null, null, 2, false, null },
                    { new Guid("04783a93-a073-49ba-b314-9a9d07505a23"), 0, null, 794.3125120595540000m, "110ca89a-9f45-4219-abe8-09840719dddd", null, null, null, false, "Christine", "Christine", "Turcotte", false, null, "Christine21", null, null, "AQAAAAEAACcQAAAAEBShahpwjPYOSRrFKeoelapqcXrApn9UCflkjWhL0WMJYxvXFpqX4S8z5WTiVZhy2Q==", null, false, null, null, 2, false, null },
                    { new Guid("0940a8d8-dd0f-40bb-9d3a-06d4d77f7f76"), 0, null, 931.6485734055370000m, "9d336d7f-8c46-4b81-8694-a16bfb6c5ef0", null, null, null, false, "Peter", "Peter", "Abbott", false, null, "Peter82", null, null, "AQAAAAEAACcQAAAAELkOBK28iMjJqJV/0lNNBSRrRxeu3a70ko8VGjNYqCik/mCeprDhI97S9OeasSDGkw==", null, false, null, null, 1, false, null },
                    { new Guid("11d33233-4672-4563-b05c-75adc34114d0"), 0, null, 975.3008689596270000m, "c24171c6-a0db-47a3-865c-60a230702a26", null, null, null, false, null, "Dominick", "Murazik", false, null, "Dominick_Murazik", null, null, "AQAAAAEAACcQAAAAEDOXeYMVgQnS/TlN1Pha8O2bRrWrKR1Wu7H7fb0u0AD4uLYThlFIc+bnK0Edv8Favw==", null, false, null, null, 2, false, null },
                    { new Guid("132b64b1-abc8-4e60-8d12-f59a86e35478"), 0, new DateTime(1961, 1, 7, 22, 42, 39, 541, DateTimeKind.Local).AddTicks(1310), 290.1505698741810000m, "35d68b32-f647-4f4e-a99d-9ba60280b1e4", null, null, null, false, null, "Ricky", "Lesch", false, null, "Ricky18", null, null, "AQAAAAEAACcQAAAAEDVtfOd/ywG2ZxEy8CsmNgAdbvO26bH/wJckhLZAw0PX/X+PuVMjLKvu9UHbuCLK8g==", null, false, null, null, 0, false, null },
                    { new Guid("14c01c35-5f30-4b72-b3ac-b488bcb95dd8"), 0, new DateTime(1945, 5, 13, 16, 33, 49, 793, DateTimeKind.Local).AddTicks(5727), 924.3331054451270000m, "90883a7d-fc77-46b9-b6f9-aabe2b7e78dd", null, null, null, false, null, "Rufus", "Hintz", false, null, "Rufus.Hintz93", null, null, "AQAAAAEAACcQAAAAEBCmFZILbmWXYU4bKs37pHkosnsPtOQ5yV+qrHrpsQV17GBpm1kfHZeIHqczGvYzCw==", null, false, null, null, 1, false, null },
                    { new Guid("1c7e7af7-236c-494b-99ee-f0360a4073ec"), 0, null, 672.3557050134640000m, "50ff08be-04c9-4dbc-947c-4f82b157c1dd", null, null, null, false, "Candace", "Candace", "Kshlerin", false, null, "Candace94", null, null, "AQAAAAEAACcQAAAAEMyaXrPe9U/42rKSXPAkgkcwFBTXcPbceYyixM81lmdUkeE1f8xERNiG/u6HPPlJLg==", null, false, null, null, 0, false, null },
                    { new Guid("1cfa453c-cf83-4679-8a13-c75e6a9abb9f"), 0, null, 399.7726034406930000m, "00870365-696d-411f-905f-28a0e22f2e9b", null, null, null, false, null, "Muriel", "Schimmel", false, null, "Muriel17", null, null, "AQAAAAEAACcQAAAAEMhz1WI5tDUXh+rXq7smXeRjqxhKEJLRMEw4sJrnEpeAzA3wn0Q4EA8oSQIEGtttyQ==", null, false, null, null, 1, false, null },
                    { new Guid("1ef52785-bff5-417e-bc0c-7f864cb6750b"), 0, null, 888.4412760600220000m, "9fdd32e0-5194-44bf-a3e8-594ba01da663", null, null, null, false, "Natasha", "Natasha", "Nienow", false, null, "Natasha_Nienow91", null, null, "AQAAAAEAACcQAAAAELM6wRkeXcmG08oP/dGlNwDlDitB1QyvgXL0+mPYUepdZTi3R4zV659y964pG3Re3Q==", null, false, null, null, 0, false, null },
                    { new Guid("235130a9-9b51-4768-b9dc-39c124ecf778"), 0, null, 676.5607429682510000m, "b97f021d-f4b7-47e3-a2c3-7942498a29d4", null, null, null, false, null, "Wilbur", "Schneider", false, null, "Wilbur.Schneider0", null, null, "AQAAAAEAACcQAAAAEKgtTzU/uff6FNdV0JmNhPhb2n0UF7xlLVJSiBHE8B9OgioXwjhKMEKt7Fu0W5lBnQ==", null, false, null, null, 2, false, null },
                    { new Guid("242f2320-4c8d-4696-b780-f7fb663444d7"), 0, new DateTime(1961, 7, 23, 1, 10, 1, 104, DateTimeKind.Local).AddTicks(7195), 85.72607447255110000m, "afc7b26b-f9c0-4f34-b788-90ee5a20a413", null, null, null, false, "Mindy", "Mindy", "Walter", false, null, "Mindy_Walter", null, null, "AQAAAAEAACcQAAAAEAWaw4kT6kyEfbmnDcheQDRsoFugRw522GCHfKfs44CL29hb88Cr6Q9hJoTOjnWfzQ==", null, false, null, null, 1, false, null },
                    { new Guid("24d43757-4120-44f4-94c2-ead9d5daddaa"), 0, null, 721.023196791430000m, "93426165-b913-42c1-8f06-61cfe51aa3b8", null, null, null, false, "Ida", "Ida", "Feeney", false, null, "Ida98", null, null, "AQAAAAEAACcQAAAAEMSwWhiGwHeawbJKYL98TGoE6Ftzbw66uGMezvC2U3VXO8SDKkIM1T0PyVCFqqo1Yw==", null, false, null, null, 2, false, null },
                    { new Guid("26733e03-7af8-4d51-b374-543ab6de1ac2"), 0, new DateTime(1989, 5, 13, 12, 22, 37, 874, DateTimeKind.Local).AddTicks(7049), 912.514214742510000m, "0d8db786-5dd4-475f-bd32-48e11306538a", null, null, null, false, null, "Saul", "Ferry", false, null, "Saul_Ferry45", null, null, "AQAAAAEAACcQAAAAEGCSHLrwMFHSc3klrA/uWHHdk2hzEf255kKLy478JngoKfxBGmL4Wz69IEi9v4ze1A==", null, false, null, null, 0, false, null },
                    { new Guid("2a14adef-3815-436b-8d13-7ce6f1a47256"), 0, new DateTime(2001, 8, 1, 19, 12, 19, 258, DateTimeKind.Local).AddTicks(4683), 500.2188323463690000m, "1d11d75e-a4b6-4cfe-9434-81e8d7ece8b2", null, null, null, false, "Henrietta", "Henrietta", "Quigley", false, null, "Henrietta_Quigley40", null, null, "AQAAAAEAACcQAAAAEKcDgDRMMPq/46w7XLchojo1J5mIp8mf9yG+EjDTg8ec2OrVDxUstzOnB1J1Zfg99Q==", null, false, null, null, 0, false, null },
                    { new Guid("2b788029-2dc1-45b0-ae16-c6b7f8ae99cd"), 0, null, 281.8671909535770000m, "39dc7011-1e44-48fa-8613-442699b267a2", null, null, null, false, "Colin", "Colin", "Fisher", false, null, "Colin.Fisher", null, null, "AQAAAAEAACcQAAAAEN9itVqvcbI75GG+roaDKUwmK6ql7Eo7lmOpQgCCN2fXkfGY6IVzAHfkPv5oRYgT0g==", null, false, null, null, 0, false, null },
                    { new Guid("30663ad5-6ea6-4216-9d1f-50ad24153778"), 0, null, 235.5764685787850000m, "445de3e8-88e0-4147-9260-9387222c9d83", null, null, null, false, "Bethany", "Bethany", "Streich", false, null, "Bethany25", null, null, "AQAAAAEAACcQAAAAELNxUgi8XkWlZuwMQW0thhFkkJHdv8uxYaFwAgWM5mpuLcvfVCf91FRrnEm/nIZKyg==", null, false, null, null, 1, false, null },
                    { new Guid("30c2c88e-4d12-44b6-bf65-d7287b23f73a"), 0, null, 119.1481253094630000m, "69158470-a118-4fd4-b69b-379c3cf310b6", null, null, null, false, null, "Ismael", "Botsford", false, null, "Ismael_Botsford", null, null, "AQAAAAEAACcQAAAAEAKfsht3u4PC+JRKJbp8cl1FoYhnK+RlIwoXh5Z03LLcVpHmZy7ZAaF/RHcu/iT0ew==", null, false, null, null, 1, false, null },
                    { new Guid("3164cccf-16f3-43e3-9d84-bdf265d0f042"), 0, null, 690.1994878211240000m, "d03db364-8be4-42ca-8e7c-4a22b8e289a8", null, null, null, false, "Dixie", "Dixie", "Grimes", false, null, "Dixie.Grimes", null, null, "AQAAAAEAACcQAAAAELx4jiYM8lhdim0cT2xFbPemr2IAtpYs1DwhJW0xEJKRK6jFuleF2zjt/tF3N9imrA==", null, false, null, null, 0, false, null },
                    { new Guid("3290441b-f700-4c29-8d43-fcfab150d3dc"), 0, new DateTime(1982, 10, 18, 6, 4, 20, 842, DateTimeKind.Local).AddTicks(4131), 191.9560655072840000m, "94b1f297-e155-4064-aa46-b4627a5133f1", null, null, null, false, "Teresa", "Teresa", "Dooley", false, null, "Teresa_Dooley32", null, null, "AQAAAAEAACcQAAAAEFZQYZMhvbXEytZysft3ZvZkWMFzm5icTmcgmlI2uGdQb1jL5hkHh9M6cGMkcJywpA==", null, false, null, null, 1, false, null },
                    { new Guid("32c3b50b-8cf7-4455-a8b1-8baea2a8672f"), 0, null, 585.5309501350990000m, "2e4e597f-580e-4de0-99cf-1c34a20fc9b9", null, null, null, false, "Mary", "Mary", "Sporer", false, null, "Mary2", null, null, "AQAAAAEAACcQAAAAEIf/wv5KpEtyB1Z1ZRcuONH8TCntPBWbgB5lFeu4Q33poXzi9yuchgV0XPQR3ebb3w==", null, false, null, null, 1, false, null },
                    { new Guid("38ded439-45ec-480b-b66c-cd5cf711bc20"), 0, null, 72.8236781278890000m, "bc5ba539-44fc-4288-8db3-c98d62132fba", null, null, null, false, null, "Hugh", "Feil", false, null, "Hugh78", null, null, "AQAAAAEAACcQAAAAEBEE7nOrofj63Ws6E2wSOJ1EuAJv8oSjMTbP5x8g+ZL3sv+H9xBxquWashr5UPZKgg==", null, false, null, null, 2, false, null },
                    { new Guid("3a2f1601-ee3c-4dc7-94ae-150487ca9b0e"), 0, new DateTime(1930, 6, 1, 2, 10, 57, 957, DateTimeKind.Local).AddTicks(7850), 627.4128598687820000m, "5fe144d5-d7b7-4285-b34a-fb5ddb030cf9", null, null, null, false, null, "Edith", "Gutmann", false, null, "Edith1", null, null, "AQAAAAEAACcQAAAAEEVXTM75/3+kslJTfrhRj5MRmZSpzJuSTz/rHex7vEtWC2Wqc+0u4Nfk8eRLr/09Ag==", null, false, null, null, 0, false, null },
                    { new Guid("3aad95ba-ed21-43ef-a29c-1f985c073977"), 0, new DateTime(1959, 5, 19, 13, 8, 5, 902, DateTimeKind.Local).AddTicks(1881), 463.3913033603250000m, "d3f8949f-90fe-4b56-ba86-796f12f9ffbd", null, null, null, false, null, "Mildred", "Purdy", false, null, "Mildred53", null, null, "AQAAAAEAACcQAAAAEBSsKM0j+0ePrRnveI45FV00AgkU0ruxA62ucDfXJ8a84QyAxU6CuUuimjeNxPKnzA==", null, false, null, null, 2, false, null },
                    { new Guid("3b19b2ed-4bbc-4aeb-893c-751284547402"), 0, null, 460.0065284428240000m, "2f19a0f2-62ca-47ea-829f-fab5d0e61b3f", null, null, null, false, "Sabrina", "Sabrina", "Gislason", false, null, "Sabrina38", null, null, "AQAAAAEAACcQAAAAEATnisnPFRGhhmqmYiqmh+h0PVwIM1Uty0nkw8XzQqYdUzFegmhkhLE1tot8GTbEkg==", null, false, null, null, 1, false, null },
                    { new Guid("3b227dd7-3231-42ef-9ca2-d488baa4ac37"), 0, new DateTime(1969, 4, 21, 7, 33, 9, 834, DateTimeKind.Local).AddTicks(6403), 56.22344754699120000m, "7fa7e7ae-8f38-436d-9ee2-74d2659cba98", null, null, null, false, null, "Leigh", "McGlynn", false, null, "Leigh22", null, null, "AQAAAAEAACcQAAAAEOkBKnhwnMInnKoKqGoRZ/EyhBsdpDfphvYV476s6pdX/4deymX9EmbY/UbY55pk4w==", null, false, null, null, 0, false, null },
                    { new Guid("3fe9f50d-4c41-4652-a0f0-937333539e23"), 0, new DateTime(1933, 11, 18, 23, 5, 55, 487, DateTimeKind.Local).AddTicks(2416), 337.8317738833150000m, "add1bf29-4aa3-415a-9d9f-6985b1294486", null, null, null, false, null, "Nettie", "Hermiston", false, null, "Nettie.Hermiston9", null, null, "AQAAAAEAACcQAAAAEDURrYi1xEG3cezTw/PDdwZsKPu2Yv9S3Crmo8hOR/kFgOUmU2eBlP4lFpF5oUwAIg==", null, false, null, null, 1, false, null },
                    { new Guid("44de57c4-9c49-4a35-a564-3fc0727409b3"), 0, new DateTime(2000, 11, 3, 19, 34, 13, 875, DateTimeKind.Local).AddTicks(4174), 291.1341497387780000m, "4c160b95-f241-4f1e-8df1-7e3832e67f16", null, null, null, false, null, "Edmond", "Larkin", false, null, "Edmond.Larkin10", null, null, "AQAAAAEAACcQAAAAEH/lsQzBL4HppPxu6LtgHyFIXmskgtGwKgMhcoNHutU0dJsY93tbWOyx1h1FYBKjxA==", null, false, null, null, 0, false, null },
                    { new Guid("4a156734-80e5-46c1-9184-e3de8106c414"), 0, new DateTime(1976, 1, 3, 19, 12, 18, 600, DateTimeKind.Local).AddTicks(3476), 924.1752761777910000m, "9861c7e9-e6f1-4249-b7bd-38fa37a683ea", null, null, null, false, null, "Matt", "Fahey", false, null, "Matt.Fahey", null, null, "AQAAAAEAACcQAAAAEGrrh2IKp2NzcSe5HrfY0qqRuFR9lJ89uf3sHoyJJxip9QNjV/cU0Xj84IvA9yPKCg==", null, false, null, null, 0, false, null },
                    { new Guid("4ae25a95-33f2-4b2d-81b6-219f34d42615"), 0, null, 943.8536397391210000m, "17244fac-6d66-4fcb-bcc3-0e9c303c151a", null, null, null, false, null, "Kim", "Feest", false, null, "Kim.Feest", null, null, "AQAAAAEAACcQAAAAEFWWfuo8gBeLhF/jm8JGDlEi6HXGnVvEhpJ9DQfUT+JythwLoed4wDO0DIgLOXFyFg==", null, false, null, null, 2, false, null },
                    { new Guid("4dde2dad-30f2-4b98-b6d2-313d1c90448a"), 0, new DateTime(1970, 12, 16, 6, 16, 54, 149, DateTimeKind.Local).AddTicks(8399), 954.3329064772090000m, "82cc66d8-193e-49ee-9873-815e4c1b073c", null, null, null, false, "Wilfred", "Wilfred", "Koch", false, null, "Wilfred.Koch88", null, null, "AQAAAAEAACcQAAAAEFPaM1zypAl+DDE0xGr9wvMkJtHIo/3ek6VsCMC9H1xudW+k2p2m9YkMUOpYUamOig==", null, false, null, null, 1, false, null },
                    { new Guid("535d42b3-27a3-4778-83ea-bca31d19bc37"), 0, null, 420.7678464389810000m, "b4447326-46a7-4809-b803-26a5de51d099", null, null, null, false, null, "Jennie", "Marquardt", false, null, "Jennie.Marquardt", null, null, "AQAAAAEAACcQAAAAEDW3sMF/ajZRQ26gP6qGCnYKVljAG0fEZ4pSiYLGNmaiM1A38XqF5QaDvvsVU8qL+g==", null, false, null, null, 0, false, null },
                    { new Guid("53c328c6-20a9-4a3b-9139-0dc53eca45b9"), 0, null, 772.1330080309930000m, "9b8788c6-1c1a-4ce8-8f79-0139ad816cbf", null, null, null, false, "Gilberto", "Gilberto", "Grimes", false, null, "Gilberto.Grimes27", null, null, "AQAAAAEAACcQAAAAEEZQ+39QCctfZHp/enYRO1xRiFDiY0MOuU73BLwFNRsHb2GarxwUcqOIFlcomulHwg==", null, false, null, null, 1, false, null },
                    { new Guid("5447c5fe-3fa0-48b5-a17e-8250194941f0"), 0, new DateTime(1953, 12, 23, 5, 16, 49, 457, DateTimeKind.Local).AddTicks(4431), 783.0559728174010000m, "138528e3-b2c7-49f6-8bd2-039a0d170643", null, null, null, false, null, "Joey", "Zboncak", false, null, "Joey.Zboncak8", null, null, "AQAAAAEAACcQAAAAEGjVwY6JrQ5sAEvwmP0Wlm8f9vV0IntlrXu2sR1SvPUTm9665ACJLyF3fxr6GGQ0bA==", null, false, null, null, 2, false, null },
                    { new Guid("54d641f7-2a06-4e4c-8299-945228d3d445"), 0, new DateTime(1925, 1, 13, 20, 27, 18, 304, DateTimeKind.Local).AddTicks(7299), 476.7727349778170000m, "74401992-536b-49ee-8bac-9b13715bdfa8", null, null, null, false, null, "Bernadette", "Orn", false, null, "Bernadette26", null, null, "AQAAAAEAACcQAAAAEHChl2T2qgE4E7TsbXO+r9/LAm+Zhz5dqGZ5YNuKLqPTiZC00krD9qdOn0BxwiLV6g==", null, false, null, null, 2, false, null },
                    { new Guid("5792acc4-4f9f-4be4-9d2b-c8e60d69bc3d"), 0, new DateTime(1982, 9, 10, 0, 26, 29, 122, DateTimeKind.Local).AddTicks(3621), 924.8725820137920000m, "f514f0d5-e569-4246-950b-d5595efa4274", null, null, null, false, "Steven", "Steven", "Carter", false, null, "Steven_Carter21", null, null, "AQAAAAEAACcQAAAAEDycOO955V08s5Dj7ms1j2qXzgjjsaVXHfZ4Xk5JbyUG11OVoIyjgVsvCI9PyN7gOg==", null, false, null, null, 2, false, null },
                    { new Guid("582c8883-3412-4ed7-98bb-b57fb389c528"), 0, new DateTime(1966, 5, 12, 14, 44, 56, 681, DateTimeKind.Local).AddTicks(9449), 281.9378159056610000m, "92133609-0887-413d-8d8b-9b43f692cef7", null, null, null, false, "Abraham", "Abraham", "Barton", false, null, "Abraham_Barton66", null, null, "AQAAAAEAACcQAAAAELMxPOsy2WqsL4NrpgtUK4egAwJQfBlEcsh5YkWXRi1DTPTfEvi8P1KF/i/Nf+tjjA==", null, false, null, null, 2, false, null },
                    { new Guid("58ac969d-fb5b-4674-8248-739bad1f3cc1"), 0, new DateTime(1998, 8, 19, 12, 4, 51, 207, DateTimeKind.Local).AddTicks(9201), 827.8503473774350000m, "c4cb5989-b97e-4564-9105-7babe3b60ccf", null, null, null, false, "Jason", "Jason", "Kassulke", false, null, "Jason_Kassulke94", null, null, "AQAAAAEAACcQAAAAEJKBUOiqi2Tcxj9sCX8NJAWYNoztpkZpbnSSn2xRpyu6uSHUFuxlaREhkTdmgz7+cg==", null, false, null, null, 0, false, null },
                    { new Guid("5b8e8690-e89f-465e-b1f1-d1691e63b5a7"), 0, null, 496.0838456472680000m, "83aec2c6-ceaa-441a-b0e2-bc297fdfb081", null, null, null, false, null, "Vicky", "Crist", false, null, "Vicky.Crist", null, null, "AQAAAAEAACcQAAAAEDjdB8hzrT7X9eYnoby/GabiiHzx0ejbvHMHlr3d4ZgI6J1+79BRUXN7772TaFR8nA==", null, false, null, null, 1, false, null },
                    { new Guid("5bedb553-aba5-4679-a39b-dd44adebf760"), 0, new DateTime(1982, 10, 10, 21, 2, 15, 799, DateTimeKind.Local).AddTicks(5394), 657.8485573066070000m, "2bad6271-ed75-4c76-9eab-b16f92a28613", null, null, null, false, null, "Geraldine", "Hegmann", false, null, "Geraldine.Hegmann38", null, null, "AQAAAAEAACcQAAAAEHfLZw+AtHQfCZSvPi6GlxhiyjUgPs6A5RJB8UsosA614zNCiZkZv1yr1gWJ1fYxHQ==", null, false, null, null, 0, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("5bf3624b-e146-4dec-86a1-3c773763a4c6"), 0, null, 352.7431300362740000m, "73de0459-6615-4ef6-809a-36698592d99c", null, null, null, false, "Dallas", "Dallas", "Ondricka", false, null, "Dallas5", null, null, "AQAAAAEAACcQAAAAEMatHGC/BFSWixpuzqcqa4B44gEBjbr8cMw498bXDCipt+60ddzY7DBOYWQEAlLS/A==", null, false, null, null, 2, false, null },
                    { new Guid("5cd7308b-03f8-4bf0-aa2f-bdb8009780b5"), 0, null, 484.4982214706030000m, "bc67266b-64a7-4c0f-8e30-43a488dabc60", null, null, null, false, null, "Randall", "Raynor", false, null, "Randall78", null, null, "AQAAAAEAACcQAAAAEEUbdqO2z5bo9VGWTiYbhejC3Xjvypld/h4MCozSs2+xyrBfSBmeWIShQtyjUjo9gA==", null, false, null, null, 0, false, null },
                    { new Guid("5d5a349f-fc23-48b4-bb0d-17e4058591db"), 0, new DateTime(1952, 1, 29, 23, 32, 2, 934, DateTimeKind.Local).AddTicks(1823), 428.7536785061060000m, "4f295474-eae0-4fad-bd4c-d4a04e166109", null, null, null, false, null, "Claude", "Macejkovic", false, null, "Claude.Macejkovic20", null, null, "AQAAAAEAACcQAAAAEHXolJGs9HNUOBvPqQqVIAADcdto18uRKOZji4/quOBEFlBitLL7Hi5222ZiqsSJvg==", null, false, null, null, 0, false, null },
                    { new Guid("5f2e044c-9c21-4457-bba7-8a8b2a3b8506"), 0, new DateTime(1981, 8, 31, 7, 55, 38, 754, DateTimeKind.Local).AddTicks(8300), 530.0903443405580000m, "f0c01739-61d6-4080-b0fd-85affe10932d", null, null, null, false, "Felix", "Felix", "Koch", false, null, "Felix_Koch87", null, null, "AQAAAAEAACcQAAAAECTFyafd4pYva6klSbKKrAOeb1YzOQ0gFKSrMKQ++paPJuMMWdzDrJSwdaMYS09C2g==", null, false, null, null, 2, false, null },
                    { new Guid("61c06f70-126e-4167-8ea8-6f5345c1b219"), 0, new DateTime(1927, 11, 24, 17, 56, 35, 497, DateTimeKind.Local).AddTicks(8137), 601.2302160424240000m, "05f28aa0-eece-4aee-833e-fb667abf6d88", null, null, null, false, "Cheryl", "Cheryl", "Paucek", false, null, "Cheryl.Paucek", null, null, "AQAAAAEAACcQAAAAEHQUwrtLnzmiXzzuemkZvqJJV4S/+hl1VC2XAWPwuQ0a+pnoGvtLJoqD/Cnrbdy46g==", null, false, null, null, 0, false, null },
                    { new Guid("61f8f359-61ee-4cd6-a874-ed293b646ec2"), 0, null, 667.8284347418280000m, "c6d41d9d-7606-495a-bc72-11141d84ea48", null, null, null, false, "Bobbie", "Bobbie", "Glover", false, null, "Bobbie28", null, null, "AQAAAAEAACcQAAAAEJ/eTrr0VKBzeLe2adt2EdF0N1dwWTjJ7CmfSDIVGJL2B/+7zSr8h3dxR5X8/77ndQ==", null, false, null, null, 0, false, null },
                    { new Guid("620ac83c-2279-47b0-b848-78fdc8ca40bb"), 0, null, 633.5789490247060000m, "8edfa339-a199-4f40-9cde-3077baa514e3", null, null, null, false, null, "Norma", "Sawayn", false, null, "Norma.Sawayn52", null, null, "AQAAAAEAACcQAAAAEDI7SfIc4DOhWxxWlQeI9/EzWSPmDU1nZBN1umcr34MSAHKZoIiwsBP0jJCNw+ZLMQ==", null, false, null, null, 0, false, null },
                    { new Guid("634d60aa-b959-4df2-80df-43de707c5d40"), 0, new DateTime(1936, 6, 17, 8, 7, 58, 332, DateTimeKind.Local).AddTicks(5897), 737.3331792219050000m, "5e431e70-4aad-4958-878e-902924031133", null, null, null, false, null, "Paul", "Howe", false, null, "Paul.Howe", null, null, "AQAAAAEAACcQAAAAEBQV4Zc3+X8HpWY8Rlo9tcpcsKIPp/1NDTXNsNtZPoIU1oVezltEBST7bFBnPexm3g==", null, false, null, null, 0, false, null },
                    { new Guid("64927f99-7a49-4d79-bbb5-792b8fcce77d"), 0, null, 465.8837254324110000m, "7aba2a65-87e8-4b2d-bacf-0f798a2d0d75", null, null, null, false, null, "Ivan", "Upton", false, null, "Ivan63", null, null, "AQAAAAEAACcQAAAAEOKDdYHJotvVgoBbmjuZFegUTU8rgFg7br8N3yhdlLhsCr7WFd5iahnnsh1hySVbdA==", null, false, null, null, 1, false, null },
                    { new Guid("64c389e8-23ea-4152-b164-f47c8b7e14a4"), 0, new DateTime(1959, 3, 20, 8, 37, 35, 316, DateTimeKind.Local).AddTicks(7908), 63.80313470925950000m, "774fab18-8058-4f2d-bdab-bc61b158f4fe", null, null, null, false, null, "Philip", "Deckow", false, null, "Philip7", null, null, "AQAAAAEAACcQAAAAEKIKxrEfUXuuhqXIAa9fnIIVT5PDUcqgAIkRf1H+vdkji3fjzsVNs88Qe2IN1rkc2A==", null, false, null, null, 2, false, null },
                    { new Guid("6506db45-d831-4985-a5fc-11c710625d57"), 0, null, 372.7136717373830000m, "3db2a721-a05e-4296-ba85-e7e411c285a0", null, null, null, false, "Ben", "Ben", "Ryan", false, null, "Ben72", null, null, "AQAAAAEAACcQAAAAECXd1+GAHOFh59U8xTH38Zyqp3r6MUJGAik0bNEqpS2QtQlNutWx1paMVZBHv+fczw==", null, false, null, null, 0, false, null },
                    { new Guid("669427c0-9731-4dd0-bf4e-5ffae835d749"), 0, null, 46.96562220998980000m, "ee198c00-a4e0-41f9-95cd-650c35d77cc9", null, null, null, false, "Sadie", "Sadie", "Lind", false, null, "Sadie98", null, null, "AQAAAAEAACcQAAAAEEWs4l6xJUILmkF5tMwV6xwUsDYgV3KWXdzVFck4n1Ts/j+YqEiqTQ59udDsIJTWAA==", null, false, null, null, 2, false, null },
                    { new Guid("66d925b4-240d-410f-8c2b-3699f28468c0"), 0, null, 511.9476832598260000m, "c6e13eba-72cd-426c-ab28-94c8c997ee8c", null, null, null, false, "Willie", "Willie", "Rodriguez", false, null, "Willie_Rodriguez7", null, null, "AQAAAAEAACcQAAAAEFX5uaH3VdBsKT827nzea93ZkHXbgXQE/Cb+j6XK3EjBrwKWgrRtn1Lm3OoR9c1QMA==", null, false, null, null, 2, false, null },
                    { new Guid("68190cb1-10ca-4b5c-9498-fa81b7074af7"), 0, null, 587.4108986077830000m, "63300304-dd1d-4403-8fd9-f0c5d763d0ac", null, null, null, false, null, "Mae", "Feil", false, null, "Mae_Feil37", null, null, "AQAAAAEAACcQAAAAEC+zzCq/gZgI1lrDa/VGmvnRaQhcCli3/BTx4fY1PHeiKYs3RO4fRqHhQnHcagUeVQ==", null, false, null, null, 0, false, null },
                    { new Guid("685bfb40-42a0-4e36-a25b-18f0594169cd"), 0, new DateTime(1945, 2, 1, 22, 41, 1, 621, DateTimeKind.Local).AddTicks(7666), 405.3396759840080000m, "aecf567c-6be1-432a-8024-29d9d64660e4", null, null, null, false, null, "Mable", "Pfannerstill", false, null, "Mable57", null, null, "AQAAAAEAACcQAAAAEIyRnX/dZQPWifEc5kJbJMHS0dGlx+6dLnD8JdRmC3T9y0C9gABPDG6NdvLgDoctIA==", null, false, null, null, 2, false, null },
                    { new Guid("6865f9d8-82f5-4c58-b134-366bbf5f73cd"), 0, new DateTime(1937, 8, 27, 3, 8, 9, 375, DateTimeKind.Local).AddTicks(2359), 405.4815812525940000m, "af7ad862-7669-48bd-9765-a9d060abcfa3", null, null, null, false, null, "Agnes", "Hartmann", false, null, "Agnes_Hartmann", null, null, "AQAAAAEAACcQAAAAEDRDdlYVVgBBjBfNLadVX27meFQ63nCri6xAtaNmsJpDR3okflhuGaSTHp4QdEh71A==", null, false, null, null, 1, false, null },
                    { new Guid("693b0291-d9ec-4538-a406-714a496a19ae"), 0, null, 577.0884572131210000m, "eb488da0-36a9-4ca8-9e96-893448af3dcd", null, null, null, false, "Orlando", "Orlando", "Waelchi", false, null, "Orlando_Waelchi", null, null, "AQAAAAEAACcQAAAAEEZbCtapkPd9TWfO88yny704QtLh9B1RlbE3ooNGcfwgqgwmYquXgbs5R3DoxS2I6w==", null, false, null, null, 1, false, null },
                    { new Guid("6ab284a3-d8eb-4902-84a1-daa40cda75ff"), 0, new DateTime(1934, 12, 3, 15, 20, 49, 164, DateTimeKind.Local).AddTicks(3417), 422.2655069316670000m, "e12a331c-cb5c-4819-a76f-59dab9df27ac", null, null, null, false, null, "Felipe", "Williamson", false, null, "Felipe2", null, null, "AQAAAAEAACcQAAAAEIWpTeUss9c/RAcuCQa8aDtyUofwBbjp2kLxTlVlnc7Y0UIzejfG6L+3lEaiVN7uAg==", null, false, null, null, 2, false, null },
                    { new Guid("6c41f334-a497-4ad3-b339-4f257df5e8a1"), 0, null, 62.77245358437070000m, "e8b1d270-a81e-4343-8176-e93c57234b40", null, null, null, false, null, "Carolyn", "Hammes", false, null, "Carolyn.Hammes96", null, null, "AQAAAAEAACcQAAAAELBf2bpX2E2OGxHtvMF+J4EQFmslj227SK6pY6aCxWwNMzmLjGg2Mhjs018lYUweew==", null, false, null, null, 0, false, null },
                    { new Guid("6ca12e95-3c92-4a88-b074-670e3a03e2ad"), 0, new DateTime(1998, 3, 1, 17, 54, 17, 816, DateTimeKind.Local).AddTicks(5550), 490.5448409503040000m, "32ed51b7-93ff-42e8-bb35-86596f331f9e", null, null, null, false, null, "Winifred", "Brakus", false, null, "Winifred76", null, null, "AQAAAAEAACcQAAAAEHy4hmjg5b89an+oqjWa9jPTOh0Udv+IqPSjIgFval2ht1mFxF+sRX9JhF2EIWEgog==", null, false, null, null, 1, false, null },
                    { new Guid("6d3494e0-2538-4c40-a783-8ac4d7431186"), 0, null, 515.081169422750000m, "61d59fdd-340d-4859-b074-2d6f2cc618d1", null, null, null, false, "Samuel", "Samuel", "Hilpert", false, null, "Samuel.Hilpert", null, null, "AQAAAAEAACcQAAAAEHuTTpd50gDmbV/ZnaveUaZl4fYTwBs0lc425JwECQ5+cfF4fLZ5+o7GyEuO5b+b0g==", null, false, null, null, 0, false, null },
                    { new Guid("6e5d52e0-6bc4-44c9-ad8d-3e771e7d1a31"), 0, new DateTime(1942, 5, 28, 2, 59, 7, 753, DateTimeKind.Local).AddTicks(9561), 861.2809479032710000m, "428de4e5-e660-4fe7-841b-060aae25aa80", null, null, null, false, "Rosa", "Rosa", "Kirlin", false, null, "Rosa.Kirlin65", null, null, "AQAAAAEAACcQAAAAEF6sIr17bO2gf2nYC4FWYjwAOqe1HiGK6VhmCenamvlazWVR5GjROrjh1io5cWVr6A==", null, false, null, null, 0, false, null },
                    { new Guid("71406865-5477-4669-8982-3ba5171b622e"), 0, new DateTime(1993, 5, 11, 11, 52, 6, 609, DateTimeKind.Local).AddTicks(7373), 54.94247653324380000m, "df39d5e6-987c-4fbd-88e1-52b0310396f1", null, null, null, false, "Abraham", "Abraham", "Gutmann", false, null, "Abraham40", null, null, "AQAAAAEAACcQAAAAEC+MSrfxHbZRye0huIYQVGWSZnfux2shNAmqpcDEPoUrAcqbeWHk7Yh6P5uyu6WBuQ==", null, false, null, null, 1, false, null },
                    { new Guid("72dfada1-6c25-439b-947e-47044854ef32"), 0, null, 242.245154821430000m, "8c1fccd8-3dcb-427f-b9c9-aa6d44269658", null, null, null, false, "Faith", "Faith", "Wolff", false, null, "Faith.Wolff88", null, null, "AQAAAAEAACcQAAAAEFnPDBdlvTK27iqkrJ/opuAbAUaWq65Pb26Sjtrs4IDjbVJGr9MiFF7Iw8v6889oTw==", null, false, null, null, 2, false, null },
                    { new Guid("7330d9a6-3b24-40c8-8897-1da54d2b22d3"), 0, null, 499.3846827835060000m, "d5fd0f19-9051-44b8-b757-045da1533fa1", null, null, null, false, null, "Gilbert", "Mohr", false, null, "Gilbert5", null, null, "AQAAAAEAACcQAAAAENoI5wTM3tqsYSPTtd5EHVlub0pO+G7DYEPfarIuaqaydV9P/lf6VGnK5cHXBcnLgQ==", null, false, null, null, 1, false, null },
                    { new Guid("743a6ccb-c6b7-44b4-b2bc-815d0e1dbc57"), 0, new DateTime(2001, 6, 22, 4, 25, 47, 729, DateTimeKind.Local).AddTicks(6582), 546.4921148112250000m, "b3045590-c34f-434c-8f89-c644f7cb7c27", null, null, null, false, null, "Antoinette", "Hermann", false, null, "Antoinette_Hermann", null, null, "AQAAAAEAACcQAAAAEN8Sw5tPLeyMPCcujFt6pnY0oqbcLP4e3FFugSMLHi+H+Prz1/CGnhmVtWmioSqasg==", null, false, null, null, 1, false, null },
                    { new Guid("763309b3-5c69-4dd3-a486-d60fc8fb447f"), 0, new DateTime(1939, 6, 19, 7, 49, 42, 452, DateTimeKind.Local).AddTicks(6249), 619.1508655575890000m, "f922e301-9810-4a44-9a97-bc5d4965ddd4", null, null, null, false, null, "Verna", "Williamson", false, null, "Verna2", null, null, "AQAAAAEAACcQAAAAEG+T0L/qngKUcdfPqqrHyXTSZoN2LaJgF6uY2UQeXb8MSKA+BebYtM8drIk2qkiuRQ==", null, false, null, null, 1, false, null },
                    { new Guid("7b51840b-3208-4d82-b7c3-d70a9d317d52"), 0, null, 364.7195079233420000m, "7eafd9cf-6d20-4764-995d-36bef0ac343a", null, null, null, false, null, "Fredrick", "Hartmann", false, null, "Fredrick4", null, null, "AQAAAAEAACcQAAAAEAfc8XOf5PJ1Lvk9fFqKnFW+Z53XD0R/NPRYZqXZ/bHRF9PJNBCckar/wBUp5GwQbA==", null, false, null, null, 2, false, null },
                    { new Guid("7f5da1b7-55fc-4da8-b92e-3e22ac562fdf"), 0, new DateTime(1958, 8, 6, 20, 18, 52, 840, DateTimeKind.Local).AddTicks(9711), 72.16720934818710000m, "6647b944-dbd6-46b3-a4fe-d37121b91e58", null, null, null, false, null, "Ruben", "Hickle", false, null, "Ruben_Hickle53", null, null, "AQAAAAEAACcQAAAAEN9W73Dw/91/sfJyfgdbMRlUQes7FKIE7mA/ST9t96pdn68ohK55/9XWKzbzKBbGvg==", null, false, null, null, 0, false, null },
                    { new Guid("8105c062-8cbb-4fd2-8bee-4f8676ba4c77"), 0, null, 831.2267050451830000m, "fe41e591-ffe9-46f8-b9d3-ff80ea047e75", null, null, null, false, "Loretta", "Loretta", "Schultz", false, null, "Loretta.Schultz", null, null, "AQAAAAEAACcQAAAAEKYpMCwRnJeOAm8qSKoDlR7bYrstJ+IBFyuzSFykwsEnDuJICzGNtyzW4Y3uckVU+Q==", null, false, null, null, 0, false, null },
                    { new Guid("81a84b38-10ae-4bdb-bc69-62d09049f2eb"), 0, null, 481.0049697733460000m, "6e988f70-09fb-4980-b6d0-112b7ca65bc6", null, null, null, false, null, "Marian", "O'Keefe", false, null, "Marian_OKeefe", null, null, "AQAAAAEAACcQAAAAEAJ41kH4JK4VVA+VCOJ69gPWE8Doe8Fxt+4z07EDKdjpD3q5o2yPvgKfDrZ4PMH4Cg==", null, false, null, null, 2, false, null },
                    { new Guid("83308a21-c0f0-4844-9a80-8f23d092f44d"), 0, new DateTime(1974, 4, 11, 12, 31, 16, 69, DateTimeKind.Local).AddTicks(4180), 52.53484988049270000m, "8f9ba4b1-b3d4-4408-9c33-74796f0f0c24", null, null, null, false, null, "Jeremiah", "Welch", false, null, "Jeremiah.Welch", null, null, "AQAAAAEAACcQAAAAEM144MaWsXviBO7rzAAEZeMhZ4oJ5xiN9oC7385zjJQKx3qsRDpiR8xWvbQLJeZNjw==", null, false, null, null, 2, false, null },
                    { new Guid("87ce0bee-feea-47c9-9746-0f0b2c6811a5"), 0, null, 584.7304787755870000m, "2e9fbfa0-a570-47c6-891e-bedc4cf3202d", null, null, null, false, null, "Juanita", "Yost", false, null, "Juanita13", null, null, "AQAAAAEAACcQAAAAEJxMEYu6OqFxDgWhs4DXWT2k1GJw8yniaNBexxumxiCbWqxx8sh6LospOUBEB9rr/Q==", null, false, null, null, 0, false, null },
                    { new Guid("8a351105-7a97-477b-b515-54d1920cf06c"), 0, null, 65.15194419254860000m, "e34a37a4-b2d2-41a7-9a67-0c4537d3dede", null, null, null, false, "Muriel", "Muriel", "Cole", false, null, "Muriel7", null, null, "AQAAAAEAACcQAAAAEBrMYQ9Ls7/qnwcu7jp0wdFCT8cZ9v/4LNG8Wdy23q4GdCrStUCcuUHf9VQs2tPc/w==", null, false, null, null, 0, false, null },
                    { new Guid("8c4ec96b-048a-4caa-ad26-d2287c2cb425"), 0, new DateTime(1928, 11, 22, 9, 29, 24, 753, DateTimeKind.Local).AddTicks(2196), 736.3833955572340000m, "b445c4b4-2a57-4c7c-8323-ac3944f71a00", null, null, null, false, null, "Sheila", "Buckridge", false, null, "Sheila.Buckridge65", null, null, "AQAAAAEAACcQAAAAELzFkDrARs/jz848aWzDTRMu7uOC/gio5iNZOXdEaIRqrS58eqJiAX7vPfat/+nQgg==", null, false, null, null, 0, false, null },
                    { new Guid("8c9ecb5d-f75a-48f5-8f8a-aa87a39bf366"), 0, new DateTime(1935, 7, 29, 13, 54, 38, 270, DateTimeKind.Local).AddTicks(4457), 367.0508141934780000m, "e7597bea-db12-4239-85bb-12069d6a5d1b", null, null, null, false, "Celia", "Celia", "Hagenes", false, null, "Celia_Hagenes63", null, null, "AQAAAAEAACcQAAAAEIYbwHJPGPXQaS6fVk/CAO+OXTWU4Dd28Xdl6zge+I9UJTGvy/HNxmHk60B4++liJw==", null, false, null, null, 2, false, null },
                    { new Guid("8e589014-f1a8-4126-8752-f93955dda864"), 0, null, 109.2313691251850000m, "e7d3870f-a241-4d5f-919a-87a5ca13c747", null, null, null, false, "Luther", "Luther", "Mohr", false, null, "Luther_Mohr", null, null, "AQAAAAEAACcQAAAAEOWUUExQBUEwVgJOSG/1mvb3BaxTgJ7GcDn6dkvSU2rzhOrr1mIymVnJ15YoYPLV2w==", null, false, null, null, 0, false, null },
                    { new Guid("8e607f33-de9b-4ad8-840d-757d73ea219a"), 0, null, 364.1853077770340000m, "6c28d3c6-d44b-485d-8cac-8eeb6c9fc793", null, null, null, false, null, "Inez", "O'Keefe", false, null, "Inez.OKeefe", null, null, "AQAAAAEAACcQAAAAEGiAO2ZLM0LnBYxn6ODlhkUZTgOnThGGBJgooD64PDdwVNNxQJf50R4+Jum7sNyP2A==", null, false, null, null, 0, false, null },
                    { new Guid("8e826ea1-a328-453a-8c98-5ad120afa1b1"), 0, new DateTime(1943, 6, 20, 2, 5, 47, 582, DateTimeKind.Local).AddTicks(317), 988.3038456830520000m, "04b24829-f95a-4eec-a6f5-9c75bfd70732", null, null, null, false, null, "Stephen", "Reichert", false, null, "Stephen_Reichert", null, null, "AQAAAAEAACcQAAAAEAWVYbsZZ2NhbBmaozWkcVfQ2zXat5jXXRpJ3TnQ/HyGnaQgtlMuuFD6gBxYL4CmEA==", null, false, null, null, 0, false, null },
                    { new Guid("92de0b42-90fc-4112-958f-bed105500378"), 0, new DateTime(1938, 7, 27, 11, 54, 22, 68, DateTimeKind.Local).AddTicks(1907), 230.0677243025030000m, "6033a94b-8dc4-4a07-a5ea-ad6297fd2ea5", null, null, null, false, null, "Joy", "Thompson", false, null, "Joy12", null, null, "AQAAAAEAACcQAAAAELWPXCNvUqH3Qj6J7d7RdeMI+bTCYVQUv//EZZoXARi/oX00FXEjVB4SMuYyi0XxlA==", null, false, null, null, 1, false, null },
                    { new Guid("94502636-bcc2-45b7-9c54-586c2d4ba805"), 0, null, 847.9715217199470000m, "e93ce0de-df23-4ea0-8b14-568bebd49676", null, null, null, false, null, "Levi", "Lang", false, null, "Levi_Lang43", null, null, "AQAAAAEAACcQAAAAEN8nOM2I34kxPsOhFlwLPDYJEMPCpJ2XbrBEM4hh1Z6iMitQQjlJz1btqRt8nUPz/g==", null, false, null, null, 1, false, null },
                    { new Guid("9489d168-a4cb-4b13-bc18-9c899024ebf2"), 0, null, 523.1300036727520000m, "e32599bd-8fcf-4912-941f-db92541c33a0", null, null, null, false, null, "Courtney", "Mayer", false, null, "Courtney_Mayer68", null, null, "AQAAAAEAACcQAAAAEKi6YHTNyfC4Rqag5morfdUNeberp5z+cESgjrAN+hhmXwMdSrYFzkqF8IogB1OYCw==", null, false, null, null, 2, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("94b1a2c9-02cb-40a3-a83c-fcbf54eeafcf"), 0, null, 892.126090028210000m, "ce4fa071-5e19-4a22-b05d-710852d7f34b", null, null, null, false, "Beatrice", "Beatrice", "Murphy", false, null, "Beatrice.Murphy39", null, null, "AQAAAAEAACcQAAAAEHIUo90SfAaZBejX24RdC4dwUDNRQ0fJz6wrBI+krxj1yqrlrlVydH/P4JExZnFO0A==", null, false, null, null, 1, false, null },
                    { new Guid("9733e81c-8e97-40c8-9dee-04c78313f7ba"), 0, new DateTime(1973, 9, 3, 14, 31, 1, 670, DateTimeKind.Local).AddTicks(229), 38.3383683096010000m, "811f7eb8-083b-4892-b254-d70aded62570", null, null, null, false, null, "Taylor", "Kuhn", false, null, "Taylor_Kuhn", null, null, "AQAAAAEAACcQAAAAEMLZ3hwwT5/YcK+yL4/R+yJKRnxWpI5VEXQCUFXnEAZTH2Lb2t9fqpKoUu3NGABh2A==", null, false, null, null, 1, false, null },
                    { new Guid("98f53e72-acee-45c0-ac25-6690ccdd4263"), 0, new DateTime(1967, 10, 4, 10, 6, 33, 460, DateTimeKind.Local).AddTicks(254), 583.6542749356060000m, "e7bb4935-8635-4b37-bb06-c9dd66121876", null, null, null, false, null, "Grady", "O'Connell", false, null, "Grady11", null, null, "AQAAAAEAACcQAAAAEGkOy8x4wxk00KGAfVwkz6ERFMH+zsFCJeSvsVDcURWCSj9AzTHtJKIKPg98zgE4Kg==", null, false, null, null, 2, false, null },
                    { new Guid("99597d95-3f59-40ef-a34e-d61ab094ab7e"), 0, null, 899.9796682674960000m, "74b9e358-5b4e-43c6-83a8-60b558627204", null, null, null, false, "Leroy", "Leroy", "Bernier", false, null, "Leroy_Bernier29", null, null, "AQAAAAEAACcQAAAAEOqs/R+SfbVKyIC4l9XL+uKlsmfHMHUIsgddUJCdTKoLMhWrhnWXlRlLsKIqiD/poQ==", null, false, null, null, 0, false, null },
                    { new Guid("9c165e41-013e-4021-8f91-3b83782c785b"), 0, null, 129.4977854516290000m, "e7cd1c9c-87d8-4fe0-a661-8f689d20ca32", null, null, null, false, "Randall", "Randall", "Thiel", false, null, "Randall.Thiel", null, null, "AQAAAAEAACcQAAAAEExNBDW6aRtBE+W8th+1hyR/WyDPOIGhRQf2rsFhqbM3SoLnBzTDBEWpCxn587JKjw==", null, false, null, null, 1, false, null },
                    { new Guid("9eaac854-9360-4cfb-bba3-17af51a976dc"), 0, new DateTime(1948, 7, 1, 13, 20, 42, 261, DateTimeKind.Local).AddTicks(1084), 232.6289261660720000m, "8b41edc0-9a22-4878-b4fc-74f66417b39d", null, null, null, false, "Deanna", "Deanna", "Christiansen", false, null, "Deanna_Christiansen", null, null, "AQAAAAEAACcQAAAAEBRzctSU49rCLZ3uGSKz6EenU1aGkPCWjrosUpHO7+DAkV8SESQNF3yvze5E7p0scA==", null, false, null, null, 2, false, null },
                    { new Guid("9f538d4b-1209-4cd8-b4f2-2f51bfea213a"), 0, new DateTime(1980, 3, 30, 6, 1, 1, 594, DateTimeKind.Local).AddTicks(3081), 974.5299811694890000m, "43bbfde6-68c2-4898-b7e7-ef2445642237", null, null, null, false, "Inez", "Inez", "Farrell", false, null, "Inez.Farrell", null, null, "AQAAAAEAACcQAAAAELXgTOZodg6t5l0mpGNfyrvUDg0RxHhOIWBPTM1QzeLk9+2dS8JDAxHSqLIV86TvXw==", null, false, null, null, 0, false, null },
                    { new Guid("9fc79f69-d005-4692-b788-f9cfafc64432"), 0, new DateTime(1965, 9, 17, 20, 46, 51, 896, DateTimeKind.Local).AddTicks(1106), 236.1026113179070000m, "237b396c-5dcb-4d63-bbec-2284987023ae", null, null, null, false, null, "Merle", "Doyle", false, null, "Merle29", null, null, "AQAAAAEAACcQAAAAEC1O1gCUAm9WP2H1j8oMJxa88GSyUtAP/PtTPvLP3xEUO753ILBRp80EPFPkmVfRUQ==", null, false, null, null, 0, false, null },
                    { new Guid("a22427e4-1bbe-46d6-8a35-e8b186eec051"), 0, new DateTime(1963, 7, 13, 21, 33, 29, 187, DateTimeKind.Local).AddTicks(6317), 553.1694081907520000m, "224e9729-e425-4fb5-bbe5-9a4aff675839", null, null, null, false, null, "Sherman", "Breitenberg", false, null, "Sherman71", null, null, "AQAAAAEAACcQAAAAEGd7VHiE0V+HJXwQPs1d1oR8bw/MCzYsgjPzrJuuP1u8Dn7teTun9FjJwxfT1LLRhg==", null, false, null, null, 0, false, null },
                    { new Guid("a47332d0-0ead-49e5-8a17-c36abbe993cf"), 0, new DateTime(1954, 5, 23, 0, 31, 21, 204, DateTimeKind.Local).AddTicks(7901), 863.989713665810000m, "c3c3e897-9dd0-48e6-b9d8-4af514bba36c", null, null, null, false, null, "Colleen", "Bednar", false, null, "Colleen69", null, null, "AQAAAAEAACcQAAAAEP1GFNqxHfZqrfSEsqMJofWy7KhX8y0GC4cRgNpxlAK0qH8CwqMbbecMspTrJQMaKg==", null, false, null, null, 2, false, null },
                    { new Guid("a9f1eefe-7275-47ff-9e37-7ed1d62a4fc4"), 0, new DateTime(1984, 7, 5, 15, 38, 29, 203, DateTimeKind.Local).AddTicks(1688), 574.95383510630000m, "de135f12-5894-415b-97c9-355f6c7e7608", null, null, null, false, null, "Karen", "Hagenes", false, null, "Karen.Hagenes42", null, null, "AQAAAAEAACcQAAAAEHirNYrKqRVZpHzyUSfzac8e8kNtVP5CZRgD/d1QTnMJ2e5t7Qlp+8SVpjdRWNjQzQ==", null, false, null, null, 0, false, null },
                    { new Guid("ab8e69e0-6bdd-4c58-aa72-b5d7b942a45c"), 0, new DateTime(1961, 9, 25, 4, 3, 44, 645, DateTimeKind.Local).AddTicks(1606), 275.6883212292040000m, "b2f88f18-1f52-44a8-8fd3-1da9b3452942", null, null, null, false, "Wilson", "Wilson", "Dickens", false, null, "Wilson71", null, null, "AQAAAAEAACcQAAAAEM7GiVOaK4+6ZuPVpOJJs85Ib7jpFnqkro92x3gwbltob/d8nQtkpyb3HFCe/G+KAA==", null, false, null, null, 0, false, null },
                    { new Guid("aeb0382e-d0de-4c7b-81a2-0b0bfcb69e7c"), 0, new DateTime(1952, 11, 8, 4, 43, 57, 308, DateTimeKind.Local).AddTicks(4409), 373.4092315771230000m, "21a8db73-661e-4f46-b0cd-5613b10b44ac", null, null, null, false, null, "Dianne", "Kerluke", false, null, "Dianne.Kerluke15", null, null, "AQAAAAEAACcQAAAAEI36dcjsJ5xHXLouFLyL3NBO9nGRM6XNjlluOpclz41djZOx0yKFRvq1Kz/jV/yr8A==", null, false, null, null, 2, false, null },
                    { new Guid("b001df7b-2cce-40f9-9c01-9b58f4ce2481"), 0, null, 935.6366698387730000m, "815d79fa-90af-4ee4-ae36-727b2a461391", null, null, null, false, null, "Pearl", "Shanahan", false, null, "Pearl77", null, null, "AQAAAAEAACcQAAAAECRieQ1f0HqKEyfhkwtGoARsCZY7V1rJI5fEmNkdu3wGk9iwq4KrooFpXT+szpvzNw==", null, false, null, null, 1, false, null },
                    { new Guid("b195e0be-df91-40ed-a05b-d94ce9e97840"), 0, new DateTime(1974, 12, 29, 23, 50, 56, 407, DateTimeKind.Local).AddTicks(9782), 571.8097488029110000m, "8765724c-e7c0-4a76-8461-592398aa0ae4", null, null, null, false, null, "Francis", "Murazik", false, null, "Francis_Murazik", null, null, "AQAAAAEAACcQAAAAEGnq3Pe0kMyil8dC3nVGJ8keqw7TRC3tqGV+Q6RV3yLlI2L1Gub7ohGexxzPsaqOrg==", null, false, null, null, 2, false, null },
                    { new Guid("b3d5fc1e-b00e-4dc5-ba6d-73cbe178995d"), 0, new DateTime(1950, 1, 27, 17, 34, 56, 705, DateTimeKind.Local).AddTicks(8463), 323.7289634650560000m, "1539335a-ca0d-4d9c-b71a-b1d5ee8e65c4", null, null, null, false, null, "Rosemary", "Okuneva", false, null, "Rosemary_Okuneva", null, null, "AQAAAAEAACcQAAAAEDmz5tDoJv04HZX8oCjUVemQCKhERn1X2A+rL/VT/JYqnUY1kqUdOSKK203bsCE5SA==", null, false, null, null, 0, false, null },
                    { new Guid("b55f356e-5abf-4de3-90bb-651e00a33527"), 0, null, 224.2083128461620000m, "330d1969-9734-4129-a7db-97b8ecdc7e1e", null, null, null, false, "Mae", "Mae", "Hessel", false, null, "Mae46", null, null, "AQAAAAEAACcQAAAAEPa+gaEMSErxJvJhHkrI+2Fea99j+w74BdKSJhFn+MSLQwuE203CEoXypDtTduac4g==", null, false, null, null, 0, false, null },
                    { new Guid("b731948f-baad-4203-a8a9-132fa96ff98a"), 0, new DateTime(1962, 5, 22, 5, 45, 43, 164, DateTimeKind.Local).AddTicks(5188), 955.7082207111250000m, "52ad868e-5b9c-4b70-aaf9-55e08a0f7d82", null, null, null, false, "Cassandra", "Cassandra", "Rolfson", false, null, "Cassandra.Rolfson", null, null, "AQAAAAEAACcQAAAAEB+YgWSRVJ1t2BLiV9Dssceiv+pPPyXu5rU6UxLDZyffbqLDCPMxmCBjO7EgrQySIg==", null, false, null, null, 2, false, null },
                    { new Guid("b78021d8-89d5-4707-8786-7fbca6c0a574"), 0, new DateTime(1996, 7, 15, 8, 0, 37, 773, DateTimeKind.Local).AddTicks(391), 150.3970622146240000m, "5d922566-2743-4f25-ad59-29b83d0e1be9", null, null, null, false, null, "Allan", "West", false, null, "Allan_West", null, null, "AQAAAAEAACcQAAAAEBrohjawWwvyjt+HX3pLPAfIQNdNCVkwC0XhLKETZZfIv5F0GHilVcGFi84goPHR/g==", null, false, null, null, 2, false, null },
                    { new Guid("b8a6b47e-6709-4c50-bef9-3ca557cdec75"), 0, null, 706.3467504375550000m, "5b8d08d2-3e3a-4624-b5cd-537dc7ec536a", null, null, null, false, "Rosie", "Rosie", "Brakus", false, null, "Rosie14", null, null, "AQAAAAEAACcQAAAAEOpqcenGdqSMDFHrg7BToCXBDXgofsPRitWCyHHa93QV2EEqf6spgJ1ICr15EbK04A==", null, false, null, null, 1, false, null },
                    { new Guid("ba84b45a-68b2-4f31-89e7-140a158d7c47"), 0, null, 394.0297129187950000m, "132dfccb-a13e-4b42-85cb-2015a786741b", null, null, null, false, "Rosalie", "Rosalie", "Wehner", false, null, "Rosalie_Wehner", null, null, "AQAAAAEAACcQAAAAEAgI71Xp6rt9p+sdjb6TAQ2WdX6G/zP+OzQYfTBMLCj2x0wjgYed5CAGXQkq5K1DPw==", null, false, null, null, 0, false, null },
                    { new Guid("bb37c6ac-6d15-402b-821c-b3cbae534856"), 0, null, 43.10209297268150000m, "1a9b3bc9-5bb7-48e8-b970-4e75d3f85ddf", null, null, null, false, "James", "James", "Konopelski", false, null, "James_Konopelski43", null, null, "AQAAAAEAACcQAAAAEE8VPAaSWn3aEa9yW0xu+IxO7BGtbSZ9Z2fBaEW8FA0vnohhGcu+bmL3HG4D43O9dg==", null, false, null, null, 2, false, null },
                    { new Guid("bd25d5bd-6b10-46a7-a317-8be87004d57c"), 0, null, 354.0860956757620000m, "97ca94bd-9b1e-4bee-92b3-8b1c6855ae47", null, null, null, false, null, "Randal", "Bogisich", false, null, "Randal_Bogisich38", null, null, "AQAAAAEAACcQAAAAEFryhXHOAbTCPuglHnJDmognc13zj9B4L7XMjp+0czmcyfBOZM55SHteAjVstn2GCA==", null, false, null, null, 0, false, null },
                    { new Guid("becdf273-f038-4c47-ac9b-7ddd9f2e1e33"), 0, null, 900.3787644089140000m, "f8be65cb-343a-4e81-8d40-dae127811cc9", null, null, null, false, null, "Ramona", "Spencer", false, null, "Ramona57", null, null, "AQAAAAEAACcQAAAAEGObhJyCI4O7O62rJCF/G2SS2bmwsw8YlGm9Jd2eoO53ZclKt0JBx9OdCX3DWnOyLA==", null, false, null, null, 2, false, null },
                    { new Guid("bf1b0969-750b-4537-8f01-ac33cbe04263"), 0, null, 700.0910340014780000m, "86ea8497-4941-4d2b-85b7-5a5111758ab4", null, null, null, false, "Paula", "Paula", "Russel", false, null, "Paula_Russel", null, null, "AQAAAAEAACcQAAAAEJJBA34BTjUX9rX/i08jsNw8qeyNxtgwEOaOMppTqkCp5eEWSIcNe1ASZaO6ibMfmQ==", null, false, null, null, 2, false, null },
                    { new Guid("c40f7e4a-2697-484f-9169-40a60f67f790"), 0, new DateTime(1993, 3, 2, 17, 26, 16, 703, DateTimeKind.Local).AddTicks(6543), 363.3047304042840000m, "cf1fe2ea-7f8f-48e4-aca4-407d1c59ff3f", null, null, null, false, null, "Todd", "Zieme", false, null, "Todd.Zieme", null, null, "AQAAAAEAACcQAAAAEOOuZZkYTmJc5oM/Y9avC9Df4DG1jUr29nxftjcXMUdS8lwvofEDAFf5bCOpyK1Q1g==", null, false, null, null, 2, false, null },
                    { new Guid("c4f5a5c9-bd9e-462d-b070-f3aaa07e0b8a"), 0, null, 996.1278742555740000m, "83c511ed-9067-476a-ba73-0b01e556d039", null, null, null, false, null, "Ernest", "Hansen", false, null, "Ernest4", null, null, "AQAAAAEAACcQAAAAEPqNSbGEXh+axcinMXfzDbHAFfr+vtfLCM9BK/F3We9Ew5+e8CZEsfqszOlRht8dIQ==", null, false, null, null, 0, false, null },
                    { new Guid("c4fa5a9f-d66e-44a1-97d0-5345b88a261c"), 0, new DateTime(1985, 3, 9, 12, 41, 46, 408, DateTimeKind.Local).AddTicks(4781), 369.162140461220000m, "7387e625-7b41-4fd7-8ada-71130eaa5c79", null, null, null, false, "Adam", "Adam", "Rosenbaum", false, null, "Adam48", null, null, "AQAAAAEAACcQAAAAECAZisKrjl8IOed95+b221sjX8jK5kp2xprCjJJZrHILifG3V3d5sLuQXvuKFFjBnQ==", null, false, null, null, 2, false, null },
                    { new Guid("c5058df5-0197-4f7a-93ba-70ba53810ad9"), 0, new DateTime(1930, 6, 19, 17, 41, 12, 305, DateTimeKind.Local).AddTicks(4083), 941.0397506575230000m, "a3025292-05f3-4b9e-96dc-f512a39d2fb2", null, null, null, false, null, "Kerry", "Yost", false, null, "Kerry.Yost", null, null, "AQAAAAEAACcQAAAAEIo+Y2ud9c5G0XKWSmsaN9Ad5KJQpZhx31KgVYjmN4UvL4uKQKUpcBW9OnlFhijERQ==", null, false, null, null, 2, false, null },
                    { new Guid("c8cd3068-cee0-4628-ad09-d40c8846af0e"), 0, null, 496.9706066044870000m, "54e2c7af-bec2-4cfd-84b6-3b2de5de3fdd", null, null, null, false, null, "Mercedes", "Marvin", false, null, "Mercedes47", null, null, "AQAAAAEAACcQAAAAEDzKprNIDvERpiIinLLWczp2AHVOk8/09Lo744R9XkgKBvFP6B0hYRO4ankUe0H73g==", null, false, null, null, 0, false, null },
                    { new Guid("cb7a8a7a-1a2f-4172-9641-73213dda6f27"), 0, null, 464.7433413563570000m, "0967fa7a-aacd-420b-8efc-746c42f33e19", null, null, null, false, "Jeremy", "Jeremy", "Ferry", false, null, "Jeremy.Ferry52", null, null, "AQAAAAEAACcQAAAAEB3VYETetCGSm6+LrXwh9IeVl0m0QSMHmMncr7dAFUUrqYZ+ybpFFaqZKIb5sC8MJg==", null, false, null, null, 0, false, null },
                    { new Guid("cc34926c-ae68-4705-be47-32dccb133e04"), 0, null, 770.5153022829870000m, "2d0c06aa-7588-4ecf-a57c-59562a602045", null, null, null, false, null, "Carmen", "Lynch", false, null, "Carmen_Lynch", null, null, "AQAAAAEAACcQAAAAEGcMulbprsA48B7pJbj5/77bQI36RqTQdhFUPvlalRPPRRhThfGDgES9qbURpNOSiA==", null, false, null, null, 2, false, null },
                    { new Guid("d1479c7e-0b52-4900-a973-4c23cad398e8"), 0, new DateTime(2002, 5, 14, 23, 24, 59, 693, DateTimeKind.Local).AddTicks(3701), 604.0638998810410000m, "ca5a3fd3-e85f-4bb8-ad5a-a34a8d97ae7a", null, null, null, false, null, "Alfonso", "Halvorson", false, null, "Alfonso82", null, null, "AQAAAAEAACcQAAAAEM5hZyZLT9gOL07D6iZIVx0K0UhhttCNjh1jH+NNYelqCWRE7Dc/F6/D/A63Y+gExA==", null, false, null, null, 0, false, null },
                    { new Guid("d18a9f4f-c9ff-487d-99c0-418797217186"), 0, null, 667.1038257021320000m, "4cf2beba-3cca-446f-bea7-1cf397fc4c3e", null, null, null, false, null, "Pearl", "Leannon", false, null, "Pearl_Leannon", null, null, "AQAAAAEAACcQAAAAEMczhMmOPPplydpGDYSC7YE0gbXwpmDFOgR0BMvihmu94D9PIJPFMVcpCSmxInvhAA==", null, false, null, null, 1, false, null },
                    { new Guid("d30c69b6-c3bb-4fb8-8db0-6868b777dc84"), 0, null, 23.35024616977930000m, "db9d0e54-67bb-44cf-88ae-f2ca3a9973b8", null, null, null, false, null, "Roberta", "White", false, null, "Roberta_White", null, null, "AQAAAAEAACcQAAAAEBbvL1uhp1Dx7ouUcmhFJPqrKsYfzealxVVwQrxHLYAyoWVrIIvgsh+rJxQ87NtAOg==", null, false, null, null, 2, false, null },
                    { new Guid("d46744dd-f7a6-44dc-9fba-85cb79426654"), 0, new DateTime(1975, 7, 19, 13, 3, 52, 763, DateTimeKind.Local).AddTicks(5090), 458.334769423660000m, "a3438b04-cdd3-44a2-b117-b39106d4154b", null, null, null, false, null, "Claudia", "Kihn", false, null, "Claudia46", null, null, "AQAAAAEAACcQAAAAEGMOOGKqUm3YUgvSZJH3oYB6TimaBN0HLGF8maSFyo/a1D+yCGEUMPmwgWqQJzRpdw==", null, false, null, null, 0, false, null },
                    { new Guid("d6cc8dd0-5158-4cdb-8023-0881d4e40a7f"), 0, new DateTime(1942, 2, 1, 7, 38, 2, 235, DateTimeKind.Local).AddTicks(8483), 115.4662336841120000m, "c8b17f2a-08f9-4330-80bd-76f67c97aac4", null, null, null, false, "Lester", "Lester", "Effertz", false, null, "Lester.Effertz70", null, null, "AQAAAAEAACcQAAAAEB9veqRl40Ye5u5RwQTbrFiY8jBH3ajzNWEi02cC9oCElAXf59kD7qi+ynmB5+OrAg==", null, false, null, null, 0, false, null },
                    { new Guid("d79bd932-238f-4d32-9f20-7df17e05ebb9"), 0, null, 69.230413626580000m, "16686322-bb3c-4fb2-ab99-5e981078ca50", null, null, null, false, null, "Betty", "D'Amore", false, null, "Betty.DAmore66", null, null, "AQAAAAEAACcQAAAAEE9ihInpZ0E+uHeaqOgF6pZXPwiR1dm7CXJ2MXexHQLF3/E7Aym53Ccz+GfToePpKg==", null, false, null, null, 2, false, null },
                    { new Guid("d8398457-7807-4084-a625-1dcc46c8c95f"), 0, new DateTime(1941, 4, 30, 4, 13, 55, 785, DateTimeKind.Local).AddTicks(6471), 641.5065894389630000m, "ca7a0522-381a-448b-9f07-5604fcfc8400", null, null, null, false, "Geneva", "Geneva", "Armstrong", false, null, "Geneva_Armstrong27", null, null, "AQAAAAEAACcQAAAAELcxTbJqp6/n8E4wE2cEONjxof06cG4ij4HmWD0SQWP/Hd4cLyc2Dda2oR2JKyo/wA==", null, false, null, null, 0, false, null },
                    { new Guid("da7a4c19-d193-47c9-af19-28e8cf7e1cc3"), 0, null, 851.389253983930000m, "09d4986e-bab5-456c-ad53-c05ea0a6db63", null, null, null, false, null, "Irvin", "Smitham", false, null, "Irvin_Smitham40", null, null, "AQAAAAEAACcQAAAAEB/9kgFhRlWzHvOETj30B0bBy3bibbUkmZD7yqwrNyImiy4KKrPEQ74Cdmy1mMIqEw==", null, false, null, null, 1, false, null },
                    { new Guid("db1c512a-6034-432f-bd76-96aa6ee64f05"), 0, null, 763.6450742495420000m, "eb7b8af5-42c7-485b-8013-273180b6f95c", null, null, null, false, null, "Molly", "Douglas", false, null, "Molly_Douglas", null, null, "AQAAAAEAACcQAAAAEI3eRPCoWjZd2WUsAgB++2MsP2oW0RveRSR+jG1qXhNpY5FmU2JGfWLs4Mq7hJWa3A==", null, false, null, null, 1, false, null },
                    { new Guid("de054994-8af5-427d-a0c9-9417c35b53e3"), 0, null, 416.2217471309520000m, "c7306ba7-78a4-4160-a9a5-2739907afbdb", null, null, null, false, "Neal", "Neal", "Davis", false, null, "Neal.Davis5", null, null, "AQAAAAEAACcQAAAAENArwpiodSW+WNDkXxNQGZFGcPSJH6NTjmQyrYVYNbeyN0Jp2Z3QRFqjii93apc8ZQ==", null, false, null, null, 1, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "DateDeleted", "DateUpdated", "Email", "EmailConfirmed", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("dfa3d718-1b18-434d-ada4-1b7333c74185"), 0, new DateTime(1960, 11, 2, 0, 50, 51, 293, DateTimeKind.Local).AddTicks(3602), 217.0693041122530000m, "d535065e-5611-4196-a85e-1832bcf709da", null, null, null, false, "Leland", "Leland", "Pollich", false, null, "Leland.Pollich35", null, null, "AQAAAAEAACcQAAAAENEXJ7HVX16cxmMbir4Ag3Tj3xBUURCrn1dCeysUx6niUurGJT6njA81U8eQrIlFZg==", null, false, null, null, 1, false, null },
                    { new Guid("e0b44f52-2c1b-4700-8955-8990365341f3"), 0, new DateTime(1993, 3, 17, 8, 19, 4, 724, DateTimeKind.Local).AddTicks(7969), 279.657108272520000m, "a575b011-d322-48af-8d30-aa0f1240a23f", null, null, null, false, null, "Morris", "O'Kon", false, null, "Morris.OKon0", null, null, "AQAAAAEAACcQAAAAEEZNJoTc3XouN+vly3c5Pk7mNlfDgsuJh6ltAhCPQYrlmoBXVhk/vj72cDrvZIYBPQ==", null, false, null, null, 0, false, null },
                    { new Guid("e0fddf16-2ee8-4b1b-96fa-728043fc5fdb"), 0, null, 739.2943107430020000m, "385dbe91-e110-4d9c-8fac-e1696d1302b7", null, null, null, false, null, "Emma", "Parisian", false, null, "Emma_Parisian", null, null, "AQAAAAEAACcQAAAAEFzKp6+CAznofDtDnOI0sDVDawTeojcK4Gd+OyvbrkcJI+bRQONzrEQ2V0t0no7x7Q==", null, false, null, null, 0, false, null },
                    { new Guid("e1789da4-c16d-474e-b5b7-e4ea2d7773e1"), 0, null, 986.261617086170000m, "940462aa-978b-456b-b242-759bca2321b1", null, null, null, false, "Roxanne", "Roxanne", "Schowalter", false, null, "Roxanne.Schowalter", null, null, "AQAAAAEAACcQAAAAEKyrW5e+UHndLN83F9liV6S5TjBGL5xf8LSHtfxBfi4oVE8EOZJ2A+xqF2e1m7nacg==", null, false, null, null, 2, false, null },
                    { new Guid("e1a64f4a-2d75-4d73-b7f3-c0bad04553b3"), 0, new DateTime(1938, 5, 26, 6, 17, 22, 627, DateTimeKind.Local).AddTicks(196), 607.415970364730000m, "5808b44c-97b5-4511-a4b4-ffbe35a53d41", null, null, null, false, null, "Roosevelt", "Gulgowski", false, null, "Roosevelt41", null, null, "AQAAAAEAACcQAAAAEGvHwZZT21Ts02C3SQ5jL8jPFEs9eOiMkW3YzmNt9JBwFgSOMDvFuACuLgW1MNeifA==", null, false, null, null, 0, false, null },
                    { new Guid("e4e5fb29-f257-4b37-aeb4-67e99ac407e2"), 0, new DateTime(1942, 6, 12, 7, 41, 46, 203, DateTimeKind.Local).AddTicks(9893), 435.601211348930000m, "e769e465-743d-4476-b33f-5e99c9aa3087", null, null, null, false, null, "Manuel", "Gorczany", false, null, "Manuel.Gorczany", null, null, "AQAAAAEAACcQAAAAEGrZfe64nGNm39FPOICoP9YWxvjhhUyPVLaMfDMEMY3tLOMJYzRP8F5rS3v/cE5Fdg==", null, false, null, null, 1, false, null },
                    { new Guid("e89e4619-a828-4fc0-91c8-e3a676f37fd8"), 0, null, 90.59959641192950000m, "af47cbbc-3f70-4f8e-8175-af3a19dada9a", null, null, null, false, "Rodolfo", "Rodolfo", "Swift", false, null, "Rodolfo29", null, null, "AQAAAAEAACcQAAAAELqjymdiu/AYvrcODNss7nEoaEqucx87QXOlTwluoOtF5k2KO9XCZom1u2C3BRFgzw==", null, false, null, null, 0, false, null },
                    { new Guid("ea96a3ad-97ab-45a2-b388-ad8ae0678a64"), 0, new DateTime(1977, 1, 13, 21, 18, 25, 778, DateTimeKind.Local).AddTicks(3267), 577.1200380253360000m, "dd92474d-1d6a-4422-9286-a682a0865420", null, null, null, false, "Rebecca", "Rebecca", "Lowe", false, null, "Rebecca.Lowe5", null, null, "AQAAAAEAACcQAAAAEMDJu4T81TdYKzCtk+VTMpTXbBNkSDEyB59VLakg0kazweo+KikvQcSUFVgdzHxFkg==", null, false, null, null, 2, false, null },
                    { new Guid("ed291a76-d17f-4119-9ae0-e51f2c416846"), 0, new DateTime(2001, 3, 24, 17, 54, 55, 487, DateTimeKind.Local).AddTicks(5729), 29.31868298853490000m, "f6599a04-a981-4d2f-a3a9-b295821b76fe", null, null, null, false, "Fredrick", "Fredrick", "Rohan", false, null, "Fredrick.Rohan44", null, null, "AQAAAAEAACcQAAAAEIiXb4mALW278FKYYMkvRVqVx26M51223yLiPasoDXz+Y4bZOwthd+Uv9uigEc5LRw==", null, false, null, null, 0, false, null },
                    { new Guid("f3705edc-b115-4663-a125-b50e5e1a8d61"), 0, null, 124.7783310382340000m, "f9c49924-4961-48cd-81af-0f71b9b509f9", null, null, null, false, null, "Samuel", "Braun", false, null, "Samuel.Braun", null, null, "AQAAAAEAACcQAAAAEMtXTooxdowZw+kh4Ulcfxepdzbh93rzEJueWCVOyD74bmk40LK9idpIw5ZhL1R3AQ==", null, false, null, null, 0, false, null },
                    { new Guid("f4833470-a758-4183-99bb-d6b2de8d76f3"), 0, null, 122.4765251691960000m, "c28a9cf2-db62-4831-a62c-6849d3c10edf", null, null, null, false, null, "Matthew", "Strosin", false, null, "Matthew.Strosin80", null, null, "AQAAAAEAACcQAAAAECfyZ2s8OyHI8zNTgzue/DAU8f5bxunp2p39poqUgqHhD/3NNwR6/xc8gmgKhdihGw==", null, false, null, null, 2, false, null },
                    { new Guid("f6c3a216-f660-4b3b-be8f-cffcc9647773"), 0, null, 973.4088567534360000m, "7d1e7c49-aa4d-4545-a51f-56319e845342", null, null, null, false, null, "Spencer", "Greenfelder", false, null, "Spencer.Greenfelder", null, null, "AQAAAAEAACcQAAAAEAjsvDw6KuvlCuogMiDU1lX18Mx4qJWLEUQIfx3Sx3Z2ji/xXRdASHtN12/XD1laLw==", null, false, null, null, 1, false, null },
                    { new Guid("fb0896f7-6e43-466f-903f-b19063ef9b4e"), 0, null, 333.3181698331450000m, "70f1375f-324f-402a-9db9-3a7191270488", null, null, null, false, null, "Brooke", "Nader", false, null, "Brooke39", null, null, "AQAAAAEAACcQAAAAEHQ9TdElleH/U5mVOnhz98ohBO5QsGgvjs11jGZICB+Ud4RDVopZkVIpSQ8FgejtuQ==", null, false, null, null, 0, false, null },
                    { new Guid("fc459777-d074-47f2-882b-cfb644e51153"), 0, new DateTime(1992, 11, 20, 4, 39, 52, 606, DateTimeKind.Local).AddTicks(4143), 701.6069275253750000m, "bd17fb19-f83f-470d-a956-b322bcc1ab2c", null, null, null, false, null, "Flora", "Hackett", false, null, "Flora20", null, null, "AQAAAAEAACcQAAAAEDrnYvHs8ZcUdaqxVQ1/97dbfEC5pKCgkQTWHeZTFfQag2wpIBh1Df0Pe9V0OsckJw==", null, false, null, null, 2, false, null }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("006bc1fb-409b-4b1a-8767-ee41e4337846"), null, null, "Mustafa37@yahoo.com", new Guid("14c01c35-5f30-4b72-b3ac-b488bcb95dd8") },
                    { new Guid("01260b08-36ad-4cc1-83cc-cb8ced142113"), null, null, "Melyna54@hotmail.com", new Guid("d6cc8dd0-5158-4cdb-8023-0881d4e40a7f") },
                    { new Guid("0133e9e1-c218-4b5c-9018-5dea0908681b"), null, null, "Damian.Beier@gmail.com", new Guid("2b788029-2dc1-45b0-ae16-c6b7f8ae99cd") },
                    { new Guid("01c437ed-3c87-4347-abac-a2423d8c4aff"), null, null, "Zakary6@gmail.com", new Guid("94b1a2c9-02cb-40a3-a83c-fcbf54eeafcf") },
                    { new Guid("03cb5331-1cde-47ff-abd7-f246ce312ed4"), null, null, "Isabell11@gmail.com", new Guid("66d925b4-240d-410f-8c2b-3699f28468c0") },
                    { new Guid("04db9828-1945-4b0d-918a-506978040ce2"), null, null, "Yesenia_Funk95@yahoo.com", new Guid("b55f356e-5abf-4de3-90bb-651e00a33527") },
                    { new Guid("05074228-8c26-4445-a9fd-b372d95a5f79"), null, null, "Kayley37@gmail.com", new Guid("cc34926c-ae68-4705-be47-32dccb133e04") },
                    { new Guid("052f2d72-1647-4924-aa68-56b08a246ab1"), null, null, "Terence.Quitzon@hotmail.com", new Guid("72dfada1-6c25-439b-947e-47044854ef32") },
                    { new Guid("058bcb19-571e-445f-9521-1caebd74ce61"), null, null, "Alejandra98@gmail.com", new Guid("f3705edc-b115-4663-a125-b50e5e1a8d61") },
                    { new Guid("05ebca08-7d36-4de6-8dce-ebbae09acde7"), null, null, "Megane86@yahoo.com", new Guid("30663ad5-6ea6-4216-9d1f-50ad24153778") },
                    { new Guid("063fb510-cd4e-4c48-a6ad-918271eb45be"), null, null, "Heather.Armstrong80@gmail.com", new Guid("87ce0bee-feea-47c9-9746-0f0b2c6811a5") },
                    { new Guid("06ade50b-211d-4f5a-af52-ec9f33b929d5"), null, null, "Yasmeen_Lueilwitz88@gmail.com", new Guid("011bfa78-8079-4b59-9a2b-bc6f6e829c86") },
                    { new Guid("08636941-b2bc-4023-bd9b-7d8c70199a12"), null, null, "Graham.Daniel87@gmail.com", new Guid("5bedb553-aba5-4679-a39b-dd44adebf760") },
                    { new Guid("0963477a-2fb5-4fb6-abd3-6adb5420ab5b"), null, null, "Mohammed_Nader7@gmail.com", new Guid("38ded439-45ec-480b-b66c-cd5cf711bc20") },
                    { new Guid("097a047c-db67-4420-8716-f01cd8e71e45"), null, null, "Diego.Block42@yahoo.com", new Guid("94502636-bcc2-45b7-9c54-586c2d4ba805") },
                    { new Guid("0aa17ff8-34a9-4ee3-99db-1eb6e6ade12d"), null, null, "Kennedi.Paucek82@hotmail.com", new Guid("d1479c7e-0b52-4900-a973-4c23cad398e8") },
                    { new Guid("0b47dae4-df1c-4d85-9f5e-66281df53b0d"), null, null, "Zack_Cronin88@yahoo.com", new Guid("becdf273-f038-4c47-ac9b-7ddd9f2e1e33") },
                    { new Guid("0bfb1848-f80b-4b92-ad86-0b50f623a37a"), null, null, "Garth.Bayer@yahoo.com", new Guid("c5058df5-0197-4f7a-93ba-70ba53810ad9") },
                    { new Guid("0d37cd99-0e02-4836-bc45-a50f2086119e"), null, null, "Ettie.Farrell@hotmail.com", new Guid("61f8f359-61ee-4cd6-a874-ed293b646ec2") },
                    { new Guid("0eef49e1-7bb9-44dd-8000-ee9454d250a9"), null, null, "Richmond_Gaylord15@yahoo.com", new Guid("92de0b42-90fc-4112-958f-bed105500378") },
                    { new Guid("0f5174a6-9c27-46db-8c34-6b0bae7b23b8"), null, null, "Anya2@yahoo.com", new Guid("b731948f-baad-4203-a8a9-132fa96ff98a") },
                    { new Guid("0f7f9d02-8db5-4528-95b4-aef410ae56bd"), null, null, "Jalen_Torp1@gmail.com", new Guid("9eaac854-9360-4cfb-bba3-17af51a976dc") },
                    { new Guid("0fec5721-d800-4306-bca8-e5b0dcbcc2f4"), null, null, "Jay_Bogan82@hotmail.com", new Guid("11d33233-4672-4563-b05c-75adc34114d0") },
                    { new Guid("10f1d668-754f-48ee-a756-7af01dc0026d"), null, null, "Declan.Hegmann@hotmail.com", new Guid("e1a64f4a-2d75-4d73-b7f3-c0bad04553b3") },
                    { new Guid("1158d5a7-1206-4bbd-98d9-cc4c48d18e10"), null, null, "Nikolas_Fisher@yahoo.com", new Guid("1c7e7af7-236c-494b-99ee-f0360a4073ec") },
                    { new Guid("119cceff-1e0f-420b-8ecc-b715123868e3"), null, null, "Yessenia33@hotmail.com", new Guid("e1789da4-c16d-474e-b5b7-e4ea2d7773e1") },
                    { new Guid("13246a24-4d79-4970-8b0b-8041e9ef8e0c"), null, null, "Susana_Grady@yahoo.com", new Guid("8e607f33-de9b-4ad8-840d-757d73ea219a") },
                    { new Guid("13938d28-ee07-412d-9198-0878ea30f4b7"), null, null, "Caesar83@gmail.com", new Guid("5b8e8690-e89f-465e-b1f1-d1691e63b5a7") },
                    { new Guid("14a8fc83-ed52-4dfb-abe5-a7086965993a"), null, null, "Zetta71@hotmail.com", new Guid("7b51840b-3208-4d82-b7c3-d70a9d317d52") },
                    { new Guid("1594247d-251a-4b6d-8bdf-452857110086"), null, null, "Brown_Lehner60@yahoo.com", new Guid("24d43757-4120-44f4-94c2-ead9d5daddaa") },
                    { new Guid("17bca971-663a-429c-870a-65882e961742"), null, null, "Abe74@yahoo.com", new Guid("99597d95-3f59-40ef-a34e-d61ab094ab7e") },
                    { new Guid("17f4a106-fb84-4d63-80d3-17c6e57fc9c2"), null, null, "Abigayle43@yahoo.com", new Guid("235130a9-9b51-4768-b9dc-39c124ecf778") },
                    { new Guid("18080d4a-890e-41c3-8707-10eb2e31f212"), null, null, "Judah1@yahoo.com", new Guid("e0fddf16-2ee8-4b1b-96fa-728043fc5fdb") },
                    { new Guid("180d336a-77e3-4585-849e-2aa9a6b32985"), null, null, "Lauriane36@hotmail.com", new Guid("c4fa5a9f-d66e-44a1-97d0-5345b88a261c") },
                    { new Guid("18b08ffc-7db4-4799-a454-34c2aa8ac235"), null, null, "Jairo_Bahringer58@yahoo.com", new Guid("6ca12e95-3c92-4a88-b074-670e3a03e2ad") },
                    { new Guid("195eadaf-fc49-4f58-930b-8a9232344b73"), null, null, "Mia.Mueller88@gmail.com", new Guid("64c389e8-23ea-4152-b164-f47c8b7e14a4") },
                    { new Guid("19ea3718-936a-4f32-a5be-cddfa1fcc20b"), null, null, "Amara.Schmidt@yahoo.com", new Guid("8c9ecb5d-f75a-48f5-8f8a-aa87a39bf366") },
                    { new Guid("19f06bcf-3429-4a10-836c-c8c1023696c8"), null, null, "Herbert_Murphy9@yahoo.com", new Guid("6506db45-d831-4985-a5fc-11c710625d57") },
                    { new Guid("1cafce75-9269-4888-8cfb-dd606df13ff2"), null, null, "Major_Rolfson46@hotmail.com", new Guid("9f538d4b-1209-4cd8-b4f2-2f51bfea213a") },
                    { new Guid("1d26659d-d6fb-408c-b025-61d68ad7aaa6"), null, null, "Layla_Hand@yahoo.com", new Guid("4ae25a95-33f2-4b2d-81b6-219f34d42615") },
                    { new Guid("1ec077e2-3d62-496b-8c55-7e1546fcc476"), null, null, "Felix45@yahoo.com", new Guid("cc34926c-ae68-4705-be47-32dccb133e04") },
                    { new Guid("20e4c862-c9b8-4857-aab7-1ea5d4601e7b"), null, null, "Zander.Weimann@yahoo.com", new Guid("04783a93-a073-49ba-b314-9a9d07505a23") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("2191c6a6-f566-4a6b-9322-c5dc9799e16e"), null, null, "Idell.Romaguera78@yahoo.com", new Guid("64c389e8-23ea-4152-b164-f47c8b7e14a4") },
                    { new Guid("2373ef12-53cd-40d0-b301-7a79e406a52a"), null, null, "Corrine.White@yahoo.com", new Guid("a22427e4-1bbe-46d6-8a35-e8b186eec051") },
                    { new Guid("239596fe-d8d1-46ec-907f-63a14f0edcf2"), null, null, "Maritza89@gmail.com", new Guid("5792acc4-4f9f-4be4-9d2b-c8e60d69bc3d") },
                    { new Guid("239bd252-d7e6-4d16-89d4-8a60e8a4e786"), null, null, "Mabelle.Wolff63@yahoo.com", new Guid("8c4ec96b-048a-4caa-ad26-d2287c2cb425") },
                    { new Guid("24831af4-7062-4992-b0ad-f2bbb84b8951"), null, null, "Turner_McDermott@yahoo.com", new Guid("c4f5a5c9-bd9e-462d-b070-f3aaa07e0b8a") },
                    { new Guid("256bd8f8-a1c1-489a-89c6-094d6759b5fb"), null, null, "Samir_Lockman@hotmail.com", new Guid("9733e81c-8e97-40c8-9dee-04c78313f7ba") },
                    { new Guid("28425c71-fc34-47ea-bc9c-25d5f75a48b1"), null, null, "Stacy_Schmidt@yahoo.com", new Guid("c4f5a5c9-bd9e-462d-b070-f3aaa07e0b8a") },
                    { new Guid("28b6af6b-f163-4e3d-a402-700e09d5641b"), null, null, "Braeden94@yahoo.com", new Guid("2a14adef-3815-436b-8d13-7ce6f1a47256") },
                    { new Guid("29019f6f-39ce-4cf7-b75a-3063d8f440fc"), null, null, "Clemmie_Abernathy@yahoo.com", new Guid("24d43757-4120-44f4-94c2-ead9d5daddaa") },
                    { new Guid("2b0c835a-feb0-42f6-abaf-426b7d79af68"), null, null, "Dixie44@gmail.com", new Guid("235130a9-9b51-4768-b9dc-39c124ecf778") },
                    { new Guid("2d83f887-b75a-42d2-920d-de2b372cd59a"), null, null, "Keeley26@hotmail.com", new Guid("b001df7b-2cce-40f9-9c01-9b58f4ce2481") },
                    { new Guid("2ecdf581-612b-44a4-9592-3c347173e212"), null, null, "Lucious.Breitenberg@gmail.com", new Guid("132b64b1-abc8-4e60-8d12-f59a86e35478") },
                    { new Guid("2fec396b-794a-4f37-8f00-83fff1563f9b"), null, null, "Thad_Cole@hotmail.com", new Guid("dfa3d718-1b18-434d-ada4-1b7333c74185") },
                    { new Guid("31a87889-3195-4fd1-9947-f6e52cb21806"), null, null, "Adrain_Gleichner@yahoo.com", new Guid("01b6209b-4724-4a1b-8ab1-22694a2927ac") },
                    { new Guid("32597353-89ea-4f5c-a4d2-0fad88d0f2a9"), null, null, "Rory_Schaden4@yahoo.com", new Guid("582c8883-3412-4ed7-98bb-b57fb389c528") },
                    { new Guid("336a0e8f-04b1-4583-9058-3874b209752d"), null, null, "Taurean.OHara80@yahoo.com", new Guid("aeb0382e-d0de-4c7b-81a2-0b0bfcb69e7c") },
                    { new Guid("359c0d1e-1c12-4b71-a99a-77454a689250"), null, null, "Nia30@hotmail.com", new Guid("3290441b-f700-4c29-8d43-fcfab150d3dc") },
                    { new Guid("35a1be76-d3d8-4f94-a5e6-3fda403e6a65"), null, null, "Briana51@hotmail.com", new Guid("011bfa78-8079-4b59-9a2b-bc6f6e829c86") },
                    { new Guid("35f50e75-c058-4de5-b4b5-998ea38c9d80"), null, null, "Kiana_Hilpert67@hotmail.com", new Guid("71406865-5477-4669-8982-3ba5171b622e") },
                    { new Guid("3604f1d9-08a6-4dd6-afb9-c9ca742bb515"), null, null, "Cooper65@gmail.com", new Guid("5f2e044c-9c21-4457-bba7-8a8b2a3b8506") },
                    { new Guid("3606e286-fc99-483e-b018-1ae0e14d024c"), null, null, "Zackery_Daugherty41@hotmail.com", new Guid("94b1a2c9-02cb-40a3-a83c-fcbf54eeafcf") },
                    { new Guid("36320294-3c98-479d-9f41-aa2304122aa0"), null, null, "Darian28@hotmail.com", new Guid("9489d168-a4cb-4b13-bc18-9c899024ebf2") },
                    { new Guid("36816255-3d80-4ba5-a838-b08a6846b3fd"), null, null, "Maximillia.Dietrich4@yahoo.com", new Guid("ed291a76-d17f-4119-9ae0-e51f2c416846") },
                    { new Guid("3772e9ce-2a9d-45e2-a267-493db68f9661"), null, null, "Rossie_Hyatt@gmail.com", new Guid("0940a8d8-dd0f-40bb-9d3a-06d4d77f7f76") },
                    { new Guid("3873bfc6-ae5e-4bc7-8bed-bd846386460b"), null, null, "Madison13@hotmail.com", new Guid("01b6209b-4724-4a1b-8ab1-22694a2927ac") },
                    { new Guid("3a7ba8bf-5001-4db1-8dec-b675061cf7e4"), null, null, "Joanne_Crooks@yahoo.com", new Guid("ed291a76-d17f-4119-9ae0-e51f2c416846") },
                    { new Guid("3a9e741c-bf36-47b3-ad14-f66214af2661"), null, null, "Rebeca.Hoeger21@hotmail.com", new Guid("53c328c6-20a9-4a3b-9139-0dc53eca45b9") },
                    { new Guid("3b29bc38-56f6-4cde-8ee6-92f9c9d36485"), null, null, "Adrien92@gmail.com", new Guid("2b788029-2dc1-45b0-ae16-c6b7f8ae99cd") },
                    { new Guid("3b4cd7e6-2c99-441a-91a3-3b9850d632d4"), null, null, "Ottis_Cole47@hotmail.com", new Guid("7f5da1b7-55fc-4da8-b92e-3e22ac562fdf") },
                    { new Guid("3bcf2d96-5c15-47e8-b60c-3a7095201cf3"), null, null, "Llewellyn54@yahoo.com", new Guid("f3705edc-b115-4663-a125-b50e5e1a8d61") },
                    { new Guid("3c4e5fc4-8b8e-49a8-9939-2f767a3d51ec"), null, null, "Herman_Upton@gmail.com", new Guid("d18a9f4f-c9ff-487d-99c0-418797217186") },
                    { new Guid("3ce64051-d47e-48af-ad7f-32a9250a47f3"), null, null, "Micheal_Cronin84@yahoo.com", new Guid("bb37c6ac-6d15-402b-821c-b3cbae534856") },
                    { new Guid("3f65afd3-d1d6-415d-bb3a-9364db7df903"), null, null, "Princess_Gibson@yahoo.com", new Guid("9733e81c-8e97-40c8-9dee-04c78313f7ba") },
                    { new Guid("40b3b587-7feb-4a9c-b1d1-5425248f11cc"), null, null, "Lyda.Schoen@yahoo.com", new Guid("8e826ea1-a328-453a-8c98-5ad120afa1b1") },
                    { new Guid("41331f52-70b7-4c2e-834e-787751aa16ed"), null, null, "Cayla.Hammes@hotmail.com", new Guid("da7a4c19-d193-47c9-af19-28e8cf7e1cc3") },
                    { new Guid("42296111-27a8-41af-a0f1-10f0278003e5"), null, null, "Kirsten.Mills11@hotmail.com", new Guid("6e5d52e0-6bc4-44c9-ad8d-3e771e7d1a31") },
                    { new Guid("43099ccd-5310-491f-b3c2-17db69c9fef0"), null, null, "Carissa56@yahoo.com", new Guid("6ab284a3-d8eb-4902-84a1-daa40cda75ff") },
                    { new Guid("4407e9c6-b853-4cd0-bfe6-e04e4b9d24c5"), null, null, "Nicolas.Ankunding83@hotmail.com", new Guid("fc459777-d074-47f2-882b-cfb644e51153") },
                    { new Guid("45aeccb7-7cd9-467e-9dba-0aa02725d964"), null, null, "Rick.Streich92@gmail.com", new Guid("aeb0382e-d0de-4c7b-81a2-0b0bfcb69e7c") },
                    { new Guid("45ca8924-1a92-4d47-b981-58311448e5b8"), null, null, "Miracle33@yahoo.com", new Guid("5cd7308b-03f8-4bf0-aa2f-bdb8009780b5") },
                    { new Guid("4689c324-37dd-440e-9c5e-99705420b767"), null, null, "Justina.Gerhold90@gmail.com", new Guid("535d42b3-27a3-4778-83ea-bca31d19bc37") },
                    { new Guid("4698b6df-1120-4b24-beca-7c130a43b173"), null, null, "Katelyn17@gmail.com", new Guid("6d3494e0-2538-4c40-a783-8ac4d7431186") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("47b67bb2-4184-40cd-a256-93b8091c0025"), null, null, "Lois46@gmail.com", new Guid("6865f9d8-82f5-4c58-b134-366bbf5f73cd") },
                    { new Guid("47e9d775-0234-4d4f-a133-6146301727c4"), null, null, "Wendell_Effertz61@hotmail.com", new Guid("61f8f359-61ee-4cd6-a874-ed293b646ec2") },
                    { new Guid("49e15c76-a16c-4643-9279-d315837f1387"), null, null, "Linnea.Tremblay25@gmail.com", new Guid("5f2e044c-9c21-4457-bba7-8a8b2a3b8506") },
                    { new Guid("4a51e0ed-3731-44d4-a27e-4bca857d902e"), null, null, "Owen.Greenfelder@yahoo.com", new Guid("6c41f334-a497-4ad3-b339-4f257df5e8a1") },
                    { new Guid("4cbd0d36-3a5d-4c0a-81bf-a4e446553cd5"), null, null, "Carter_Witting@gmail.com", new Guid("e0fddf16-2ee8-4b1b-96fa-728043fc5fdb") },
                    { new Guid("4e4b4aaa-104f-4c20-abec-720f01d9e9ab"), null, null, "Guido97@gmail.com", new Guid("669427c0-9731-4dd0-bf4e-5ffae835d749") },
                    { new Guid("4fc94aef-74b5-4fe9-a169-dcd4c0242365"), null, null, "Tremaine30@yahoo.com", new Guid("535d42b3-27a3-4778-83ea-bca31d19bc37") },
                    { new Guid("4fe76ae7-d3e9-4b37-8ed0-f38c828ce2b8"), null, null, "Sarah_Streich56@yahoo.com", new Guid("763309b3-5c69-4dd3-a486-d60fc8fb447f") },
                    { new Guid("4fe8c152-cefb-4489-9c8e-0e6013bfce5a"), null, null, "Monty_Bayer26@gmail.com", new Guid("e0b44f52-2c1b-4700-8955-8990365341f3") },
                    { new Guid("50ce11a3-01f6-4c4e-9467-61e64352c4bb"), null, null, "Curtis.Zemlak@yahoo.com", new Guid("d79bd932-238f-4d32-9f20-7df17e05ebb9") },
                    { new Guid("516eeb4f-acdc-4e26-9e6f-76cda15059d6"), null, null, "Dora83@gmail.com", new Guid("dfa3d718-1b18-434d-ada4-1b7333c74185") },
                    { new Guid("51b74427-3803-4ec1-8803-71431f30a381"), null, null, "Leonora.Bashirian34@gmail.com", new Guid("743a6ccb-c6b7-44b4-b2bc-815d0e1dbc57") },
                    { new Guid("52a9df81-c5be-4593-8233-1b80c344f32d"), null, null, "Addison_Yost13@gmail.com", new Guid("26733e03-7af8-4d51-b374-543ab6de1ac2") },
                    { new Guid("530d57d5-eebf-4069-9676-3df7ad0ace48"), null, null, "Kareem_Rempel@yahoo.com", new Guid("68190cb1-10ca-4b5c-9498-fa81b7074af7") },
                    { new Guid("530f0951-4372-4261-9003-f52af92cbac1"), null, null, "Liliana_Sauer22@hotmail.com", new Guid("8a351105-7a97-477b-b515-54d1920cf06c") },
                    { new Guid("55e0a32d-2a22-45cd-bf74-12a53c9a0023"), null, null, "Roberta.Beer@hotmail.com", new Guid("c5058df5-0197-4f7a-93ba-70ba53810ad9") },
                    { new Guid("57523a4e-468b-42b3-8e2e-752d6db2a227"), null, null, "Madaline.Bahringer@hotmail.com", new Guid("685bfb40-42a0-4e36-a25b-18f0594169cd") },
                    { new Guid("59b4ebf5-4b6c-406f-9193-53405bdb2ec4"), null, null, "Julianne96@hotmail.com", new Guid("6ca12e95-3c92-4a88-b074-670e3a03e2ad") },
                    { new Guid("5a5a17a1-6ddb-46a8-894b-4b056a6f0153"), null, null, "Fidel_Friesen76@yahoo.com", new Guid("8e589014-f1a8-4126-8752-f93955dda864") },
                    { new Guid("5aec82ea-071e-450e-a3d4-6f6b0f244726"), null, null, "Isabel36@hotmail.com", new Guid("ea96a3ad-97ab-45a2-b388-ad8ae0678a64") },
                    { new Guid("5b7b3c5c-1bfb-4104-bdf1-c514f37daae0"), null, null, "Otto_Collier@gmail.com", new Guid("c4fa5a9f-d66e-44a1-97d0-5345b88a261c") },
                    { new Guid("5ca763e8-0a11-40e1-b3e6-75d0e1331758"), null, null, "Ben_Runte@gmail.com", new Guid("81a84b38-10ae-4bdb-bc69-62d09049f2eb") },
                    { new Guid("5dcf5419-8d34-465b-8fe7-14e4d6e8ad8c"), null, null, "Bulah_Pouros88@gmail.com", new Guid("c40f7e4a-2697-484f-9169-40a60f67f790") },
                    { new Guid("60e7c4c9-77fe-481d-a4b0-f8ffebac70cc"), null, null, "Maximillian.Rath@hotmail.com", new Guid("66d925b4-240d-410f-8c2b-3699f28468c0") },
                    { new Guid("61394389-2b89-4a14-bf51-40c9eb89ad5e"), null, null, "Brooks.Lueilwitz57@hotmail.com", new Guid("5d5a349f-fc23-48b4-bb0d-17e4058591db") },
                    { new Guid("6295ac75-b0c4-4742-b786-e3a40562a0ea"), null, null, "Braulio.Kohler@gmail.com", new Guid("bb37c6ac-6d15-402b-821c-b3cbae534856") },
                    { new Guid("62afb63c-c59f-461f-ad46-a9f13ab94e1c"), null, null, "Timothy78@gmail.com", new Guid("4dde2dad-30f2-4b98-b6d2-313d1c90448a") },
                    { new Guid("63607828-79d4-4279-b120-1b3ed1dacb92"), null, null, "Paxton.Kuhlman@gmail.com", new Guid("8105c062-8cbb-4fd2-8bee-4f8676ba4c77") },
                    { new Guid("6385fd1a-43d9-4b20-b702-a332e49fdde4"), null, null, "Delaney_Conroy2@hotmail.com", new Guid("242f2320-4c8d-4696-b780-f7fb663444d7") },
                    { new Guid("6679b6cb-3c2e-4170-a418-2d6965b7d9dc"), null, null, "Khalid38@hotmail.com", new Guid("de054994-8af5-427d-a0c9-9417c35b53e3") },
                    { new Guid("66f1da7d-b77c-4a2a-b513-2b6006571123"), null, null, "Lucius4@gmail.com", new Guid("61c06f70-126e-4167-8ea8-6f5345c1b219") },
                    { new Guid("67b01c6f-b7c1-4551-bd34-cca0fdffa616"), null, null, "Alphonso_Balistreri4@hotmail.com", new Guid("cb7a8a7a-1a2f-4172-9641-73213dda6f27") },
                    { new Guid("68659f76-01f0-4531-b805-86d4e1044a02"), null, null, "Reece.Stoltenberg68@hotmail.com", new Guid("a22427e4-1bbe-46d6-8a35-e8b186eec051") },
                    { new Guid("6976f132-61d0-448e-bdaa-e7dddb5bceef"), null, null, "Easton.Daugherty67@gmail.com", new Guid("3164cccf-16f3-43e3-9d84-bdf265d0f042") },
                    { new Guid("6b302c0c-5dc0-4e23-963e-eac941e65118"), null, null, "Westley40@hotmail.com", new Guid("7330d9a6-3b24-40c8-8897-1da54d2b22d3") },
                    { new Guid("6bc7060d-cbbe-479f-901a-f63e4da4fc14"), null, null, "Marlin.Altenwerth@yahoo.com", new Guid("83308a21-c0f0-4844-9a80-8f23d092f44d") },
                    { new Guid("6be95aa0-6c7f-4535-a4f2-06579dedf388"), null, null, "Loyal_Zieme@gmail.com", new Guid("bd25d5bd-6b10-46a7-a317-8be87004d57c") },
                    { new Guid("6d249c47-9c30-4e17-b86a-af87513c9cd9"), null, null, "Darrion_Mante34@gmail.com", new Guid("743a6ccb-c6b7-44b4-b2bc-815d0e1dbc57") },
                    { new Guid("6ed29f62-2f03-4188-8b9b-92a2a510425e"), null, null, "Adrienne_Murazik94@hotmail.com", new Guid("94502636-bcc2-45b7-9c54-586c2d4ba805") },
                    { new Guid("6f8ec93a-f69a-43d4-8cf2-c62efaf972ae"), null, null, "Savanah.Wolff@hotmail.com", new Guid("5cd7308b-03f8-4bf0-aa2f-bdb8009780b5") },
                    { new Guid("7225caf7-4248-4cb7-9b60-65b774800c29"), null, null, "Darlene.Vandervort@hotmail.com", new Guid("87ce0bee-feea-47c9-9746-0f0b2c6811a5") },
                    { new Guid("7248a013-0a12-47fe-8bbb-1287a9c8a6b5"), null, null, "Ruthie_Brown89@gmail.com", new Guid("8a351105-7a97-477b-b515-54d1920cf06c") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("7352d05c-e153-438d-863a-cb6e6546e479"), null, null, "Laverne.Hermiston9@hotmail.com", new Guid("b195e0be-df91-40ed-a05b-d94ce9e97840") },
                    { new Guid("7413f19d-7842-4009-8e71-d36760d82245"), null, null, "Chris1@hotmail.com", new Guid("03206cd0-0a83-4f1d-a4c3-c69cd723a833") },
                    { new Guid("7442781a-0f41-440f-9b73-12b77857465f"), null, null, "Roselyn_Frami16@yahoo.com", new Guid("9f538d4b-1209-4cd8-b4f2-2f51bfea213a") },
                    { new Guid("74d48e9c-4e8f-4fe3-a531-50d1e1a6d7e4"), null, null, "Raquel46@hotmail.com", new Guid("14c01c35-5f30-4b72-b3ac-b488bcb95dd8") },
                    { new Guid("75695c94-53e0-4021-a388-6869f6f751f1"), null, null, "Adah.Jaskolski73@gmail.com", new Guid("58ac969d-fb5b-4674-8248-739bad1f3cc1") },
                    { new Guid("75c82cc4-1ba9-4914-b472-77292eb27342"), null, null, "Elyssa97@yahoo.com", new Guid("a47332d0-0ead-49e5-8a17-c36abbe993cf") },
                    { new Guid("75ef2229-0350-4b68-b925-784cc1afc875"), null, null, "Baylee.Boyer24@yahoo.com", new Guid("30c2c88e-4d12-44b6-bf65-d7287b23f73a") },
                    { new Guid("77d8c36e-cef2-48ec-a09b-71f85382e90c"), null, null, "Raoul.Stroman51@yahoo.com", new Guid("c8cd3068-cee0-4628-ad09-d40c8846af0e") },
                    { new Guid("7871209f-ba38-4dac-bf1c-bfa18f9eaadc"), null, null, "Jacey15@gmail.com", new Guid("025318b8-b68a-4350-ad23-a79900a71bf6") },
                    { new Guid("7ca0ce5d-7a8f-4adf-8f64-3d59f14da60c"), null, null, "Josh46@yahoo.com", new Guid("3b227dd7-3231-42ef-9ca2-d488baa4ac37") },
                    { new Guid("7ca352a2-fb11-4275-ac3a-deef6d7c4b32"), null, null, "Jackeline.Kshlerin4@hotmail.com", new Guid("72dfada1-6c25-439b-947e-47044854ef32") },
                    { new Guid("7d5dee53-c29d-4c66-bd10-58e10bf2ec40"), null, null, "Lucas9@hotmail.com", new Guid("b78021d8-89d5-4707-8786-7fbca6c0a574") },
                    { new Guid("804045e0-48a9-4a6d-a4fb-accf220bf6a1"), null, null, "Montana.Pacocha91@gmail.com", new Guid("db1c512a-6034-432f-bd76-96aa6ee64f05") },
                    { new Guid("8076be36-b95b-4335-b966-9d67b8e278a8"), null, null, "Clay_Rutherford74@gmail.com", new Guid("e1789da4-c16d-474e-b5b7-e4ea2d7773e1") },
                    { new Guid("810aa958-6ce5-4bdc-9c49-e2d94cb22f23"), null, null, "Gertrude.Bashirian@gmail.com", new Guid("becdf273-f038-4c47-ac9b-7ddd9f2e1e33") },
                    { new Guid("81f076ba-a8c4-4b04-a477-04a7e3f5fb13"), null, null, "Nathaniel.Zieme25@gmail.com", new Guid("3b19b2ed-4bbc-4aeb-893c-751284547402") },
                    { new Guid("82f5962d-3e7a-4038-ae26-e2e800993d9a"), null, null, "Hubert81@hotmail.com", new Guid("71406865-5477-4669-8982-3ba5171b622e") },
                    { new Guid("82fe4cd6-41ee-47d5-acf7-a814a9598c79"), null, null, "Ella43@hotmail.com", new Guid("d30c69b6-c3bb-4fb8-8db0-6868b777dc84") },
                    { new Guid("838a44ef-956d-4984-8826-7aa14ffc3ed8"), null, null, "Sally.Kuhn@hotmail.com", new Guid("6ab284a3-d8eb-4902-84a1-daa40cda75ff") },
                    { new Guid("844246ed-203d-411d-b645-c846c87e91f2"), null, null, "Alexandria.Rohan77@yahoo.com", new Guid("8c9ecb5d-f75a-48f5-8f8a-aa87a39bf366") },
                    { new Guid("85a9094b-4a00-4e37-aa68-b6ece0a8ed92"), null, null, "Rosalinda.Lowe30@gmail.com", new Guid("d46744dd-f7a6-44dc-9fba-85cb79426654") },
                    { new Guid("86739fa5-de4d-43a5-b26a-7a6c70b8c9fd"), null, null, "Dianna.McGlynn@hotmail.com", new Guid("0940a8d8-dd0f-40bb-9d3a-06d4d77f7f76") },
                    { new Guid("86cca152-ab57-4801-af64-718c77e9181c"), null, null, "Jayce_Parisian@gmail.com", new Guid("693b0291-d9ec-4538-a406-714a496a19ae") },
                    { new Guid("86d43b87-868f-402d-9ba4-797bed15fd0a"), null, null, "Javonte_Grady17@gmail.com", new Guid("54d641f7-2a06-4e4c-8299-945228d3d445") },
                    { new Guid("87792505-cf95-42cf-ba81-d7f4f489735d"), null, null, "Kallie_Fahey@hotmail.com", new Guid("9c165e41-013e-4021-8f91-3b83782c785b") },
                    { new Guid("895e72b9-8b08-4aa4-a240-6f3d8e56dce1"), null, null, "Sadie.Stoltenberg@yahoo.com", new Guid("ba84b45a-68b2-4f31-89e7-140a158d7c47") },
                    { new Guid("8ae8f0bd-1360-45c2-b88a-63a76a23b910"), null, null, "Allison83@hotmail.com", new Guid("2a14adef-3815-436b-8d13-7ce6f1a47256") },
                    { new Guid("8c041e8c-e1a6-4167-af7e-420f082d086b"), null, null, "Adalberto_Hagenes@hotmail.com", new Guid("61c06f70-126e-4167-8ea8-6f5345c1b219") },
                    { new Guid("8ce88f50-96f3-4a83-aa13-ddf269d05635"), null, null, "Joy.Kihn23@yahoo.com", new Guid("32c3b50b-8cf7-4455-a8b1-8baea2a8672f") },
                    { new Guid("91f2a7a0-1c52-43c8-b72a-b6eb0b3310dc"), null, null, "Rocio_Tremblay28@yahoo.com", new Guid("a47332d0-0ead-49e5-8a17-c36abbe993cf") },
                    { new Guid("92f2ca58-f9c7-4c14-9d04-5b8b6c0e2c87"), null, null, "Linwood_Will19@gmail.com", new Guid("5447c5fe-3fa0-48b5-a17e-8250194941f0") },
                    { new Guid("931fd7db-dd58-43f1-8363-86d7b4c94152"), null, null, "Delbert85@gmail.com", new Guid("b3d5fc1e-b00e-4dc5-ba6d-73cbe178995d") },
                    { new Guid("932dd413-c26f-4980-8035-9b26e9dc96e5"), null, null, "Joany22@yahoo.com", new Guid("a9f1eefe-7275-47ff-9e37-7ed1d62a4fc4") },
                    { new Guid("93b59de1-2d72-4c0e-90f1-e880c53c9911"), null, null, "Heloise68@yahoo.com", new Guid("3b227dd7-3231-42ef-9ca2-d488baa4ac37") },
                    { new Guid("95632752-16fa-49e3-98d8-5909d8d698f1"), null, null, "Earlene.Hintz@hotmail.com", new Guid("da7a4c19-d193-47c9-af19-28e8cf7e1cc3") },
                    { new Guid("96626ba7-cf29-4e7c-af13-4bc9cf4922f3"), null, null, "Wayne14@gmail.com", new Guid("1ef52785-bff5-417e-bc0c-7f864cb6750b") },
                    { new Guid("96a3494f-ec53-4517-b06a-ffcb0939da24"), null, null, "Rachel96@hotmail.com", new Guid("3a2f1601-ee3c-4dc7-94ae-150487ca9b0e") },
                    { new Guid("96b2c44f-e3a7-45bd-bf01-cd5b4705a3bf"), null, null, "Helene.Huels80@gmail.com", new Guid("98f53e72-acee-45c0-ac25-6690ccdd4263") },
                    { new Guid("96e67357-9195-4e91-b6d4-f529d5606913"), null, null, "Antonette_Hettinger26@gmail.com", new Guid("d1479c7e-0b52-4900-a973-4c23cad398e8") },
                    { new Guid("97e30814-c907-4a9d-9bd7-928dd7bb501f"), null, null, "Corine49@yahoo.com", new Guid("26733e03-7af8-4d51-b374-543ab6de1ac2") },
                    { new Guid("98349f00-79a2-459e-babd-8f3530df82a5"), null, null, "Robyn.Strosin14@gmail.com", new Guid("5bf3624b-e146-4dec-86a1-3c773763a4c6") },
                    { new Guid("9902ea6c-72fb-4d27-8c47-62edfad7e983"), null, null, "Earnestine95@yahoo.com", new Guid("03206cd0-0a83-4f1d-a4c3-c69cd723a833") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("99772c9d-d152-46e0-8df5-59acd58374a1"), null, null, "Anahi39@hotmail.com", new Guid("e4e5fb29-f257-4b37-aeb4-67e99ac407e2") },
                    { new Guid("9ba15a44-2fea-4439-9b2e-c80d1569fa7a"), null, null, "Adrianna47@yahoo.com", new Guid("58ac969d-fb5b-4674-8248-739bad1f3cc1") },
                    { new Guid("9e611390-8c2b-41c3-a187-4cae2d2b46b2"), null, null, "Lula_Harber@gmail.com", new Guid("7330d9a6-3b24-40c8-8897-1da54d2b22d3") },
                    { new Guid("9e9902af-0a51-46e1-8551-583d8e57f244"), null, null, "Desmond48@gmail.com", new Guid("4a156734-80e5-46c1-9184-e3de8106c414") },
                    { new Guid("9ea6257e-6c48-4ea0-9c0a-620e1c5b83db"), null, null, "Leone14@yahoo.com", new Guid("b001df7b-2cce-40f9-9c01-9b58f4ce2481") },
                    { new Guid("9ebbd20b-ef61-4823-82fc-eca61c31eaa0"), null, null, "Toni_Bartell@hotmail.com", new Guid("634d60aa-b959-4df2-80df-43de707c5d40") },
                    { new Guid("a07f5e0d-d8fd-45af-a505-607e2783347c"), null, null, "Viola58@yahoo.com", new Guid("32c3b50b-8cf7-4455-a8b1-8baea2a8672f") },
                    { new Guid("a1475702-1aaf-48e4-a3db-54252a4faa9b"), null, null, "Tabitha72@gmail.com", new Guid("7b51840b-3208-4d82-b7c3-d70a9d317d52") },
                    { new Guid("a2ba2e29-7508-41d7-bb1e-e4bbdb502e1d"), null, null, "Helene49@yahoo.com", new Guid("11d33233-4672-4563-b05c-75adc34114d0") },
                    { new Guid("a4a8925b-0c22-4a6d-a5b1-0b4530077098"), null, null, "Frankie.Effertz16@gmail.com", new Guid("3b19b2ed-4bbc-4aeb-893c-751284547402") },
                    { new Guid("a5322fc3-30f7-408a-b39d-af79800e749f"), null, null, "Tiara.Zboncak71@gmail.com", new Guid("242f2320-4c8d-4696-b780-f7fb663444d7") },
                    { new Guid("a5357889-82d8-41ae-aab7-1d33306e8ad4"), null, null, "Emanuel_Lockman44@gmail.com", new Guid("7f5da1b7-55fc-4da8-b92e-3e22ac562fdf") },
                    { new Guid("a556f617-8bdb-42bd-8b54-222a7b7aefb2"), null, null, "Sasha40@gmail.com", new Guid("99597d95-3f59-40ef-a34e-d61ab094ab7e") },
                    { new Guid("a58a4c84-ba3b-4b1b-a99e-c2fa25d9e9a1"), null, null, "Ila_Shanahan33@hotmail.com", new Guid("c8cd3068-cee0-4628-ad09-d40c8846af0e") },
                    { new Guid("a5fd894b-27a5-4b0d-9e79-5ff2128503ea"), null, null, "Keara_Schowalter@hotmail.com", new Guid("3290441b-f700-4c29-8d43-fcfab150d3dc") },
                    { new Guid("a641ce2f-27c5-4b1d-ab7f-5ff0d3755f9d"), null, null, "Elna.Brekke75@yahoo.com", new Guid("5d5a349f-fc23-48b4-bb0d-17e4058591db") },
                    { new Guid("a74c6445-d598-452e-b006-ab343f9cfcd2"), null, null, "Mabelle99@hotmail.com", new Guid("8e607f33-de9b-4ad8-840d-757d73ea219a") },
                    { new Guid("a7cdad0b-f397-4909-9302-69bca5f70ece"), null, null, "Alia_DuBuque3@gmail.com", new Guid("634d60aa-b959-4df2-80df-43de707c5d40") },
                    { new Guid("a7e7f98d-f8ec-4cca-a4f0-9a4b06d08424"), null, null, "Casandra_Effertz@hotmail.com", new Guid("582c8883-3412-4ed7-98bb-b57fb389c528") },
                    { new Guid("a7f38211-6cb6-4351-926d-9b34947f3eaf"), null, null, "Delores.Abernathy67@yahoo.com", new Guid("bf1b0969-750b-4537-8f01-ac33cbe04263") },
                    { new Guid("a890482c-1207-46db-a965-c0a2aa6ec49c"), null, null, "Nettie_Gusikowski@yahoo.com", new Guid("b78021d8-89d5-4707-8786-7fbca6c0a574") },
                    { new Guid("a8cfc4da-1375-4797-b90f-925d580e4a68"), null, null, "Estel58@yahoo.com", new Guid("5bedb553-aba5-4679-a39b-dd44adebf760") },
                    { new Guid("a8ddf3c7-c0ea-4879-8a3d-f8dd57eaa23b"), null, null, "Penelope_Herman48@yahoo.com", new Guid("3aad95ba-ed21-43ef-a29c-1f985c073977") },
                    { new Guid("a942b88c-0a94-420f-9bff-0d05b658bd61"), null, null, "Robbie32@yahoo.com", new Guid("a9f1eefe-7275-47ff-9e37-7ed1d62a4fc4") },
                    { new Guid("a958f6b7-9a9b-4c84-b0d6-c4de2ded2ce3"), null, null, "Jacinthe.Grady39@hotmail.com", new Guid("53c328c6-20a9-4a3b-9139-0dc53eca45b9") },
                    { new Guid("aa7365f2-0212-466e-8e34-fda2ec4b4aa8"), null, null, "Vickie_Bashirian@gmail.com", new Guid("d8398457-7807-4084-a625-1dcc46c8c95f") },
                    { new Guid("ab0d8dc4-75d2-410c-ac64-ec728d8a2aa6"), null, null, "Riley.Corwin81@gmail.com", new Guid("d18a9f4f-c9ff-487d-99c0-418797217186") },
                    { new Guid("ab79b56c-7942-4037-9e96-a01cb23557b9"), null, null, "Zola_Lowe50@yahoo.com", new Guid("620ac83c-2279-47b0-b848-78fdc8ca40bb") },
                    { new Guid("adb2c171-1539-4620-a28c-03498af90e4d"), null, null, "Reba_Waters29@yahoo.com", new Guid("ab8e69e0-6bdd-4c58-aa72-b5d7b942a45c") },
                    { new Guid("ae91e00a-6081-4f9b-bb27-f2f8602e2730"), null, null, "Nikolas29@yahoo.com", new Guid("38ded439-45ec-480b-b66c-cd5cf711bc20") },
                    { new Guid("aec851c7-ea07-4505-9e57-a01dc5bd0826"), null, null, "Bertram.Sanford37@yahoo.com", new Guid("fb0896f7-6e43-466f-903f-b19063ef9b4e") },
                    { new Guid("b03330fb-63b7-476c-a4e1-a0d23c80d00d"), null, null, "Lavonne_Okuneva88@hotmail.com", new Guid("e89e4619-a828-4fc0-91c8-e3a676f37fd8") },
                    { new Guid("b2e75b55-07cc-42fb-899d-20aa587d9fa1"), null, null, "Bryon_Wolf84@yahoo.com", new Guid("6506db45-d831-4985-a5fc-11c710625d57") },
                    { new Guid("b2f8ffa4-7b0b-441b-9e18-eebd18f1d05a"), null, null, "Leif_Jacobi26@gmail.com", new Guid("fc459777-d074-47f2-882b-cfb644e51153") },
                    { new Guid("b368b277-a075-457e-8682-b61552f64bf4"), null, null, "Hortense.Pollich@gmail.com", new Guid("6d3494e0-2538-4c40-a783-8ac4d7431186") },
                    { new Guid("b433a200-f650-4a53-9cd9-0dfbec421efa"), null, null, "Wayne_Wolff49@gmail.com", new Guid("132b64b1-abc8-4e60-8d12-f59a86e35478") },
                    { new Guid("b4baef71-97aa-4c83-b006-6860a654a382"), null, null, "Karianne_Keeling@gmail.com", new Guid("30663ad5-6ea6-4216-9d1f-50ad24153778") },
                    { new Guid("b4d091e1-84a4-4eeb-acfd-cde9b886b838"), null, null, "Marge_Mueller@gmail.com", new Guid("b8a6b47e-6709-4c50-bef9-3ca557cdec75") },
                    { new Guid("b657ee87-4127-4585-80be-fbab5523cbae"), null, null, "Colton.Runte@hotmail.com", new Guid("e4e5fb29-f257-4b37-aeb4-67e99ac407e2") },
                    { new Guid("b9837c96-77d2-49f3-b3c9-242b82ae0fee"), null, null, "Alexandria_OKeefe@gmail.com", new Guid("f6c3a216-f660-4b3b-be8f-cffcc9647773") },
                    { new Guid("b9c4d613-336e-457d-b910-ad58a437bd19"), null, null, "Carlos25@hotmail.com", new Guid("669427c0-9731-4dd0-bf4e-5ffae835d749") },
                    { new Guid("b9d9cfe6-4ce5-4a45-a09a-495a0a2ce4db"), null, null, "Lelah_Feeney80@hotmail.com", new Guid("44de57c4-9c49-4a35-a564-3fc0727409b3") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("ba2301a1-6e53-47e8-af8e-2a290de38efc"), null, null, "Bonnie_Corkery70@gmail.com", new Guid("d8398457-7807-4084-a625-1dcc46c8c95f") },
                    { new Guid("baafba28-7fa0-4158-a35e-07831fb9ab13"), null, null, "Lacy38@hotmail.com", new Guid("3aad95ba-ed21-43ef-a29c-1f985c073977") },
                    { new Guid("badf80aa-f24d-4e7d-87ce-ec9d71d30aa4"), null, null, "Alva_Haag@yahoo.com", new Guid("3fe9f50d-4c41-4652-a0f0-937333539e23") },
                    { new Guid("bb059ab9-d962-4552-ab3c-eb9c64c398e7"), null, null, "Pedro_Hills26@hotmail.com", new Guid("64927f99-7a49-4d79-bbb5-792b8fcce77d") },
                    { new Guid("bcf65c84-b55f-4cc7-a173-9ec67b3552d0"), null, null, "Brown_Bechtelar7@hotmail.com", new Guid("693b0291-d9ec-4538-a406-714a496a19ae") },
                    { new Guid("bd2377d4-c393-40dc-b4aa-708e044b62dd"), null, null, "Ardella_Kunde@hotmail.com", new Guid("4a156734-80e5-46c1-9184-e3de8106c414") },
                    { new Guid("bd9d79e8-f246-48eb-a136-1afa47d03eea"), null, null, "Erna78@yahoo.com", new Guid("6865f9d8-82f5-4c58-b134-366bbf5f73cd") },
                    { new Guid("be22ad7e-70ab-4442-9341-9b0a1203d484"), null, null, "Fleta21@hotmail.com", new Guid("3164cccf-16f3-43e3-9d84-bdf265d0f042") },
                    { new Guid("be529c4f-6e25-49b3-863c-a3865d1e68e0"), null, null, "Benedict52@yahoo.com", new Guid("db1c512a-6034-432f-bd76-96aa6ee64f05") },
                    { new Guid("be563eb4-181a-4316-82db-f7e7fb79e6a7"), null, null, "Spencer70@yahoo.com", new Guid("de054994-8af5-427d-a0c9-9417c35b53e3") },
                    { new Guid("be780dd3-40b1-44d8-a28d-6ca3c7f9ef95"), null, null, "Durward_Howe@yahoo.com", new Guid("763309b3-5c69-4dd3-a486-d60fc8fb447f") },
                    { new Guid("beecbf58-3e1a-4cf6-8c1f-dd7dbb915e17"), null, null, "Shany.Strosin@gmail.com", new Guid("81a84b38-10ae-4bdb-bc69-62d09049f2eb") },
                    { new Guid("c011f648-2e80-4953-b538-3967173ced6d"), null, null, "Dameon_Pollich@yahoo.com", new Guid("f6c3a216-f660-4b3b-be8f-cffcc9647773") },
                    { new Guid("c0b394f5-f3b6-45d1-a4e1-1401ac5a7c94"), null, null, "Ebba.Denesik@yahoo.com", new Guid("1ef52785-bff5-417e-bc0c-7f864cb6750b") },
                    { new Guid("c45eb81f-d2e6-439f-908d-21ae4afa7747"), null, null, "Kameron.Ritchie71@yahoo.com", new Guid("8e826ea1-a328-453a-8c98-5ad120afa1b1") },
                    { new Guid("c4a4cf7d-acd8-4a37-b3cd-407bc60d73bf"), null, null, "Earnestine64@yahoo.com", new Guid("1cfa453c-cf83-4679-8a13-c75e6a9abb9f") },
                    { new Guid("c515cf9b-6ee2-4f27-8fb2-87ef9544ddfe"), null, null, "Victoria.Erdman@yahoo.com", new Guid("685bfb40-42a0-4e36-a25b-18f0594169cd") },
                    { new Guid("ca812928-261c-430e-b19e-f6f1f66d595d"), null, null, "Cordia_Jerde62@yahoo.com", new Guid("4ae25a95-33f2-4b2d-81b6-219f34d42615") },
                    { new Guid("cceead6c-7bb4-44bb-8d9b-dc36d148f41e"), null, null, "Lindsay_Vandervort@gmail.com", new Guid("92de0b42-90fc-4112-958f-bed105500378") },
                    { new Guid("cd4e9448-17ca-4535-b32d-2b4241a3ca38"), null, null, "Prudence_Watsica49@hotmail.com", new Guid("9489d168-a4cb-4b13-bc18-9c899024ebf2") },
                    { new Guid("cdafd076-3fe9-4db6-8d51-439991cd4748"), null, null, "Clotilde.Goyette65@hotmail.com", new Guid("fb0896f7-6e43-466f-903f-b19063ef9b4e") },
                    { new Guid("cdcecfc7-99c6-4f7f-bf00-484585336345"), null, null, "Harold.Welch@hotmail.com", new Guid("b195e0be-df91-40ed-a05b-d94ce9e97840") },
                    { new Guid("cf8281a7-b25a-4bf7-a7d3-ddb520433499"), null, null, "Loma64@hotmail.com", new Guid("620ac83c-2279-47b0-b848-78fdc8ca40bb") },
                    { new Guid("d1732425-f1d0-4399-8285-6fe122df5a4e"), null, null, "Mable_Harvey@yahoo.com", new Guid("9fc79f69-d005-4692-b788-f9cfafc64432") },
                    { new Guid("d2746aec-a1a2-4c18-b6e9-51047261a688"), null, null, "Jensen_Orn86@yahoo.com", new Guid("3a2f1601-ee3c-4dc7-94ae-150487ca9b0e") },
                    { new Guid("d2e4d25d-4400-4afe-ab19-f68313504e50"), null, null, "Chris.Bradtke32@yahoo.com", new Guid("8c4ec96b-048a-4caa-ad26-d2287c2cb425") },
                    { new Guid("d3615e2d-b70e-4f08-ab8d-27aac6a0536c"), null, null, "Teresa_Muller32@gmail.com", new Guid("5b8e8690-e89f-465e-b1f1-d1691e63b5a7") },
                    { new Guid("d5101cea-30dd-4bf8-a506-ad59058bffb8"), null, null, "Mckayla44@yahoo.com", new Guid("025318b8-b68a-4350-ad23-a79900a71bf6") },
                    { new Guid("d6c30b9d-9c71-48a0-b406-3ded02cc9e91"), null, null, "Kevon1@hotmail.com", new Guid("d46744dd-f7a6-44dc-9fba-85cb79426654") },
                    { new Guid("d6d80dde-f066-477f-b83e-4ce716754ed3"), null, null, "Irwin73@hotmail.com", new Guid("b55f356e-5abf-4de3-90bb-651e00a33527") },
                    { new Guid("d82c077a-bc31-424b-b303-88539565fd78"), null, null, "Raleigh.Vandervort@hotmail.com", new Guid("bd25d5bd-6b10-46a7-a317-8be87004d57c") },
                    { new Guid("d8a53923-5192-49be-ba3c-0fd192a5bd5b"), null, null, "Pascale.Christiansen@yahoo.com", new Guid("98f53e72-acee-45c0-ac25-6690ccdd4263") },
                    { new Guid("d8a6b53a-d985-4dbe-add0-95885ea135e1"), null, null, "Shayne.Yundt@gmail.com", new Guid("9c165e41-013e-4021-8f91-3b83782c785b") },
                    { new Guid("d8c11cdd-6a9b-4751-8870-ff5a0d72c681"), null, null, "Sadie.Kub@hotmail.com", new Guid("8e589014-f1a8-4126-8752-f93955dda864") },
                    { new Guid("da10560a-c5d3-4aaa-9e9b-5da6d5a18e97"), null, null, "Alverta21@gmail.com", new Guid("f4833470-a758-4183-99bb-d6b2de8d76f3") },
                    { new Guid("da44efe3-64b7-4298-845c-531d7028827d"), null, null, "Aiden.OKeefe@hotmail.com", new Guid("4dde2dad-30f2-4b98-b6d2-313d1c90448a") },
                    { new Guid("db83849c-7962-4f39-8d13-7c88c513172b"), null, null, "Reuben7@yahoo.com", new Guid("b3d5fc1e-b00e-4dc5-ba6d-73cbe178995d") },
                    { new Guid("dbd86844-1d09-4872-87e8-002dbd71dab9"), null, null, "Wilhelmine_Abshire@gmail.com", new Guid("ab8e69e0-6bdd-4c58-aa72-b5d7b942a45c") },
                    { new Guid("dc5c05e0-ed9e-4f3f-945e-55ab42d659cd"), null, null, "Eliza96@gmail.com", new Guid("5792acc4-4f9f-4be4-9d2b-c8e60d69bc3d") },
                    { new Guid("df354f54-547f-4fba-b5aa-7f9c74bc697e"), null, null, "Amir_Johnson99@yahoo.com", new Guid("b8a6b47e-6709-4c50-bef9-3ca557cdec75") },
                    { new Guid("df7c723a-7890-48c7-a740-0e2998593d8c"), null, null, "Orville_OConner80@hotmail.com", new Guid("c40f7e4a-2697-484f-9169-40a60f67f790") },
                    { new Guid("e107a96c-b027-4b77-896e-fa64f510226f"), null, null, "Freddie24@gmail.com", new Guid("d79bd932-238f-4d32-9f20-7df17e05ebb9") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateDeleted", "DateUpdated", "EmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("e19910fd-8a9a-4e23-b251-25a30c675fcc"), null, null, "Camila_Hyatt79@gmail.com", new Guid("ba84b45a-68b2-4f31-89e7-140a158d7c47") },
                    { new Guid("e2960a41-ae3d-443f-8684-20eb41a331e0"), null, null, "Matilda42@yahoo.com", new Guid("64927f99-7a49-4d79-bbb5-792b8fcce77d") },
                    { new Guid("e5ceb199-74b3-4eff-aac3-1f2fffd71307"), null, null, "Frederick.Boehm10@gmail.com", new Guid("e1a64f4a-2d75-4d73-b7f3-c0bad04553b3") },
                    { new Guid("e977143d-65a7-459f-be29-7193f0530b1a"), null, null, "Vernon.Will@yahoo.com", new Guid("e89e4619-a828-4fc0-91c8-e3a676f37fd8") },
                    { new Guid("eaa003c3-e9cf-4cd4-8b54-92f086a38ba8"), null, null, "Meagan94@gmail.com", new Guid("6c41f334-a497-4ad3-b339-4f257df5e8a1") },
                    { new Guid("eaf6b157-b8f1-42cd-b488-d59c2244fe50"), null, null, "Irwin_Ziemann@hotmail.com", new Guid("54d641f7-2a06-4e4c-8299-945228d3d445") },
                    { new Guid("ebc41e40-cdb8-4dab-b8fc-472bcc58cb6e"), null, null, "Domenica76@yahoo.com", new Guid("d6cc8dd0-5158-4cdb-8023-0881d4e40a7f") },
                    { new Guid("ec1ad6c4-5edb-461d-9038-0843d3cc2df5"), null, null, "Adah.Becker@hotmail.com", new Guid("30c2c88e-4d12-44b6-bf65-d7287b23f73a") },
                    { new Guid("ec72b4f4-6ccf-403c-940e-3cc913202b60"), null, null, "Leonor12@yahoo.com", new Guid("3fe9f50d-4c41-4652-a0f0-937333539e23") },
                    { new Guid("ed54d146-5c94-4582-ace9-96ce95e68e86"), null, null, "Tommie40@gmail.com", new Guid("04783a93-a073-49ba-b314-9a9d07505a23") },
                    { new Guid("ef96aa34-4dac-4829-9f67-0c2098b5ef4e"), null, null, "Shania49@gmail.com", new Guid("d30c69b6-c3bb-4fb8-8db0-6868b777dc84") },
                    { new Guid("f04aee74-0bff-43f2-a530-32ae06c142c7"), null, null, "Jovany82@yahoo.com", new Guid("9eaac854-9360-4cfb-bba3-17af51a976dc") },
                    { new Guid("f21d33c5-3d1d-47a4-a929-af05c3488bae"), null, null, "Gregory80@hotmail.com", new Guid("83308a21-c0f0-4844-9a80-8f23d092f44d") },
                    { new Guid("f3f493b5-1028-4777-aee7-7ae089ebec2a"), null, null, "Reyna.Reinger89@hotmail.com", new Guid("68190cb1-10ca-4b5c-9498-fa81b7074af7") },
                    { new Guid("f44d7762-37cd-422d-8ba9-e220e10f1c7e"), null, null, "Mackenzie_Muller@hotmail.com", new Guid("bf1b0969-750b-4537-8f01-ac33cbe04263") },
                    { new Guid("f4b10a8d-3127-42dd-942c-320a5c5d7968"), null, null, "Patience_Walsh45@yahoo.com", new Guid("1c7e7af7-236c-494b-99ee-f0360a4073ec") },
                    { new Guid("f5673954-da3a-42fc-b74d-51a7dac3c23b"), null, null, "Constance64@hotmail.com", new Guid("44de57c4-9c49-4a35-a564-3fc0727409b3") },
                    { new Guid("f8063816-6944-4f19-a734-c54c97376408"), null, null, "Isidro_OConnell@hotmail.com", new Guid("6e5d52e0-6bc4-44c9-ad8d-3e771e7d1a31") },
                    { new Guid("f836857d-dc2d-4b0d-9b8c-73a49703e2a5"), null, null, "Freddy_Runolfsdottir44@gmail.com", new Guid("cb7a8a7a-1a2f-4172-9641-73213dda6f27") },
                    { new Guid("f850063e-0cff-4df8-96d7-ad3fe11f08eb"), null, null, "Olen23@gmail.com", new Guid("b731948f-baad-4203-a8a9-132fa96ff98a") },
                    { new Guid("f874d7ea-55a7-45be-a10c-12d379099e59"), null, null, "Retta.Fahey24@hotmail.com", new Guid("1cfa453c-cf83-4679-8a13-c75e6a9abb9f") },
                    { new Guid("f988dd32-225e-46d8-b924-fa22ad2ddf81"), null, null, "Murphy.Batz@yahoo.com", new Guid("e0b44f52-2c1b-4700-8955-8990365341f3") },
                    { new Guid("fa94884b-1778-49c0-8df1-c30b0660f300"), null, null, "Eileen93@hotmail.com", new Guid("8105c062-8cbb-4fd2-8bee-4f8676ba4c77") },
                    { new Guid("fb6f1bde-3089-48be-9d5b-130134be8353"), null, null, "Raul.Funk@gmail.com", new Guid("5447c5fe-3fa0-48b5-a17e-8250194941f0") },
                    { new Guid("fbe76579-fe8f-4e53-9a65-f9440629f9c2"), null, null, "Dennis73@yahoo.com", new Guid("9fc79f69-d005-4692-b788-f9cfafc64432") },
                    { new Guid("fe8a598a-e240-424f-b2b8-2d3394704435"), null, null, "Rylee26@hotmail.com", new Guid("ea96a3ad-97ab-45a2-b388-ad8ae0678a64") },
                    { new Guid("fed255f4-4060-46e2-be0f-086d314b76b8"), null, null, "Dean.Dietrich@yahoo.com", new Guid("5bf3624b-e146-4dec-86a1-3c773763a4c6") },
                    { new Guid("ffefe9e5-07f1-4ce3-ae26-9e3006484338"), null, null, "Richmond_OConnell@gmail.com", new Guid("f4833470-a758-4183-99bb-d6b2de8d76f3") }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("01abbe05-9ab6-4a2b-9d6a-a77510021322"), "857", "5117338843127344", null, null, new Guid("b8a6b47e-6709-4c50-bef9-3ca557cdec75"), "03/21" },
                    { new Guid("04035955-21b3-4595-809a-af3efc212ec2"), "783", "6066682516097507", null, null, new Guid("8a351105-7a97-477b-b515-54d1920cf06c"), "05/11" },
                    { new Guid("04aa0372-b2e0-4e34-b557-538473defcd7"), "685", "8898799618281467", null, null, new Guid("2b788029-2dc1-45b0-ae16-c6b7f8ae99cd"), "09/14" },
                    { new Guid("053a2a47-08ba-421c-99a6-c153a4da5e94"), "356", "5486130935716265", null, null, new Guid("bf1b0969-750b-4537-8f01-ac33cbe04263"), "08/02" },
                    { new Guid("068120c2-637e-4ba5-84a8-52de18559066"), "370", "6706448552750966", null, null, new Guid("30663ad5-6ea6-4216-9d1f-50ad24153778"), "11/18" },
                    { new Guid("06943348-6143-47eb-b8e2-5a530b6563cc"), "616", "3850019219981042", null, null, new Guid("1ef52785-bff5-417e-bc0c-7f864cb6750b"), "09/14" },
                    { new Guid("06a96b62-b070-4b7a-a6e5-c6ddce4886ac"), "936", "8895598101246446", null, null, new Guid("d18a9f4f-c9ff-487d-99c0-418797217186"), "08/15" },
                    { new Guid("06fe96c4-a672-4ca7-99c3-27b9d355ed4c"), "208", "1804109258161899", null, null, new Guid("30663ad5-6ea6-4216-9d1f-50ad24153778"), "01/27" },
                    { new Guid("07bbba69-e102-4b9b-b844-6238db2e2a64"), "546", "3506148140765566", null, null, new Guid("5447c5fe-3fa0-48b5-a17e-8250194941f0"), "09/17" },
                    { new Guid("0d304362-38e9-46a2-aa42-099e898415a3"), "162", "6579987625029874", null, null, new Guid("92de0b42-90fc-4112-958f-bed105500378"), "08/04" },
                    { new Guid("0ee94d71-e2bd-407f-aa27-cf66d5312d4b"), "121", "7867830184936472", null, null, new Guid("61f8f359-61ee-4cd6-a874-ed293b646ec2"), "07/21" },
                    { new Guid("0f9fba47-4124-4a57-a470-2327efa14b7d"), "872", "6872873924808279", null, null, new Guid("4a156734-80e5-46c1-9184-e3de8106c414"), "11/12" },
                    { new Guid("1077e0b9-e699-402c-91d2-ed129300a158"), "202", "9382684474632338", null, null, new Guid("1ef52785-bff5-417e-bc0c-7f864cb6750b"), "02/24" },
                    { new Guid("1086a2be-75f8-447e-a3a9-c6ef8269e917"), "611", "1012207727198047", null, null, new Guid("11d33233-4672-4563-b05c-75adc34114d0"), "04/03" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("11124270-9001-4393-a49b-b6ee663adbbd"), "976", "2688423426308634", null, null, new Guid("64927f99-7a49-4d79-bbb5-792b8fcce77d"), "12/04" },
                    { new Guid("132599e3-bc73-4640-a0cd-34981070e9af"), "947", "5555602809466798", null, null, new Guid("aeb0382e-d0de-4c7b-81a2-0b0bfcb69e7c"), "03/19" },
                    { new Guid("1496faea-eb0d-44bc-a8c6-be52ba5abdf4"), "611", "7471319815345749", null, null, new Guid("a22427e4-1bbe-46d6-8a35-e8b186eec051"), "08/11" },
                    { new Guid("157642f6-d64b-4e44-847c-90fe75906554"), "160", "2028627337936397", null, null, new Guid("f6c3a216-f660-4b3b-be8f-cffcc9647773"), "08/03" },
                    { new Guid("1625abda-0657-405d-ac14-de0997c3ea13"), "814", "2573342510875115", null, null, new Guid("e0fddf16-2ee8-4b1b-96fa-728043fc5fdb"), "03/18" },
                    { new Guid("1964bdde-704d-4ac7-8287-94e58e57c0a9"), "171", "6072286189067367", null, null, new Guid("1c7e7af7-236c-494b-99ee-f0360a4073ec"), "09/28" },
                    { new Guid("19b990e9-7ade-4b46-9e8c-236ca4378064"), "787", "6320532563325171", null, null, new Guid("cc34926c-ae68-4705-be47-32dccb133e04"), "11/19" },
                    { new Guid("1a02d51e-6ac4-419d-8a74-7620be2e87f5"), "518", "3013083975816082", null, null, new Guid("3fe9f50d-4c41-4652-a0f0-937333539e23"), "10/12" },
                    { new Guid("1b73a46c-b619-4d65-9cd1-b058b33d482b"), "637", "4638828372630807", null, null, new Guid("a47332d0-0ead-49e5-8a17-c36abbe993cf"), "03/24" },
                    { new Guid("1c132d97-449f-4cfd-b3c1-15ce04098c9c"), "664", "5370164206781376", null, null, new Guid("b195e0be-df91-40ed-a05b-d94ce9e97840"), "09/27" },
                    { new Guid("1c5879cc-8478-4613-b74f-790173f5f578"), "858", "6734282829090998", null, null, new Guid("693b0291-d9ec-4538-a406-714a496a19ae"), "07/19" },
                    { new Guid("1d7ce8d9-daa5-4a63-875b-05dab4dfaf26"), "470", "8908931956217353", null, null, new Guid("bb37c6ac-6d15-402b-821c-b3cbae534856"), "11/02" },
                    { new Guid("1e1d9321-6476-4cd2-92a4-081ff0e0d007"), "265", "7774446369655743", null, null, new Guid("44de57c4-9c49-4a35-a564-3fc0727409b3"), "07/15" },
                    { new Guid("1e267522-efb8-4760-8a09-1da4f5012c0c"), "113", "3883384610224438", null, null, new Guid("b001df7b-2cce-40f9-9c01-9b58f4ce2481"), "01/03" },
                    { new Guid("1f2d59e5-0951-43b2-8311-b54d9532a627"), "310", "6511802993497000", null, null, new Guid("5bedb553-aba5-4679-a39b-dd44adebf760"), "11/15" },
                    { new Guid("1fc25c59-68b2-4d45-89b3-86321643a296"), "432", "6713858183146178", null, null, new Guid("6865f9d8-82f5-4c58-b134-366bbf5f73cd"), "07/03" },
                    { new Guid("1fcfeb83-891f-4ba5-bf94-56a7c3b3ec46"), "973", "7466459806457335", null, null, new Guid("6e5d52e0-6bc4-44c9-ad8d-3e771e7d1a31"), "08/11" },
                    { new Guid("1fe441d1-e07e-4677-becc-1106e142bcf9"), "241", "4094804260532140", null, null, new Guid("ea96a3ad-97ab-45a2-b388-ad8ae0678a64"), "02/10" },
                    { new Guid("2000484d-fa01-4632-9370-ee29715394d7"), "437", "9455551067706528", null, null, new Guid("44de57c4-9c49-4a35-a564-3fc0727409b3"), "06/27" },
                    { new Guid("20be6dd6-76cc-4adb-b10e-09e129f12255"), "435", "1542788215856408", null, null, new Guid("f4833470-a758-4183-99bb-d6b2de8d76f3"), "04/28" },
                    { new Guid("21309cdb-73a4-4908-bc6c-e47cc1a41d71"), "807", "5960449511925209", null, null, new Guid("9fc79f69-d005-4692-b788-f9cfafc64432"), "03/28" },
                    { new Guid("22355aa5-3faa-487b-bac6-361ba4cff78d"), "370", "6899572191138185", null, null, new Guid("025318b8-b68a-4350-ad23-a79900a71bf6"), "06/03" },
                    { new Guid("22c22703-287b-4a7f-a676-4c0a3247af70"), "779", "2234582885881975", null, null, new Guid("8c4ec96b-048a-4caa-ad26-d2287c2cb425"), "07/10" },
                    { new Guid("26f3b475-c376-41a8-b8fb-6ee92e650eb2"), "685", "3889155816336939", null, null, new Guid("61f8f359-61ee-4cd6-a874-ed293b646ec2"), "07/08" },
                    { new Guid("27854bd7-2ca4-47ab-a323-1a162eb4f19c"), "077", "3305827877566164", null, null, new Guid("61c06f70-126e-4167-8ea8-6f5345c1b219"), "05/26" },
                    { new Guid("294b3b3b-ed25-4947-9acc-3654a091ee68"), "652", "5651503744368451", null, null, new Guid("5bedb553-aba5-4679-a39b-dd44adebf760"), "11/26" },
                    { new Guid("2b3fdafd-dc5d-4d47-9314-27aeca73a0f5"), "755", "3201708119070349", null, null, new Guid("1cfa453c-cf83-4679-8a13-c75e6a9abb9f"), "10/04" },
                    { new Guid("2b6c0c6d-c7f7-4696-b13a-b656b83fde9a"), "074", "1481565286145717", null, null, new Guid("01b6209b-4724-4a1b-8ab1-22694a2927ac"), "09/07" },
                    { new Guid("2b6f6c2a-0481-4162-a734-04aac65c2dc0"), "305", "4441522927205129", null, null, new Guid("68190cb1-10ca-4b5c-9498-fa81b7074af7"), "12/13" },
                    { new Guid("2b75d1b1-94c9-4be9-8d2d-317244e58cf7"), "794", "1522972011323855", null, null, new Guid("ba84b45a-68b2-4f31-89e7-140a158d7c47"), "03/04" },
                    { new Guid("2bef1c0e-dca8-480b-bad0-c4891aa6adb2"), "386", "2446698753859001", null, null, new Guid("5b8e8690-e89f-465e-b1f1-d1691e63b5a7"), "05/26" },
                    { new Guid("2dd50163-2491-43a2-ac48-1e520cca37e4"), "723", "8554830336377096", null, null, new Guid("b001df7b-2cce-40f9-9c01-9b58f4ce2481"), "01/07" },
                    { new Guid("2e8c6328-6237-4a72-a42a-587469d3a6e1"), "488", "2645959279369378", null, null, new Guid("3164cccf-16f3-43e3-9d84-bdf265d0f042"), "03/11" },
                    { new Guid("31410e3e-82c1-4fbd-976e-5c5225507b58"), "239", "5474306070087782", null, null, new Guid("5bf3624b-e146-4dec-86a1-3c773763a4c6"), "08/07" },
                    { new Guid("31914118-832a-4f4a-961a-1f3725f6f2c6"), "914", "9103096475790851", null, null, new Guid("53c328c6-20a9-4a3b-9139-0dc53eca45b9"), "04/01" },
                    { new Guid("34b0e9f8-e825-4d11-8ae7-3b0c07954318"), "100", "9722712456699268", null, null, new Guid("db1c512a-6034-432f-bd76-96aa6ee64f05"), "11/05" },
                    { new Guid("3693608e-79f2-4194-b84b-6197efc4e1aa"), "499", "2900798148485894", null, null, new Guid("becdf273-f038-4c47-ac9b-7ddd9f2e1e33"), "01/25" },
                    { new Guid("395fe650-fed1-4522-a805-2aa6c1833b07"), "363", "2686235067985534", null, null, new Guid("c4f5a5c9-bd9e-462d-b070-f3aaa07e0b8a"), "04/28" },
                    { new Guid("3979d218-c690-47eb-8be6-cce3842ebd29"), "030", "3493451756711815", null, null, new Guid("8e826ea1-a328-453a-8c98-5ad120afa1b1"), "09/06" },
                    { new Guid("3a4a3bd3-8932-4f57-a545-6c73ad503e4e"), "213", "7057728233557734", null, null, new Guid("bf1b0969-750b-4537-8f01-ac33cbe04263"), "11/28" },
                    { new Guid("3ac8e806-6e7a-4e14-aa46-d78ad77d79d4"), "059", "6895904423939091", null, null, new Guid("6ab284a3-d8eb-4902-84a1-daa40cda75ff"), "02/09" },
                    { new Guid("3f31ee28-7b3c-49d5-aa06-e6ea55febc5f"), "124", "7020140299192370", null, null, new Guid("d30c69b6-c3bb-4fb8-8db0-6868b777dc84"), "10/05" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("3fed4c8a-1d77-420d-90b7-79f9ea0ae1fc"), "050", "9164299091315692", null, null, new Guid("cb7a8a7a-1a2f-4172-9641-73213dda6f27"), "07/04" },
                    { new Guid("40f5d398-c753-4afd-b99e-0e835cb72775"), "080", "2468940412901450", null, null, new Guid("535d42b3-27a3-4778-83ea-bca31d19bc37"), "07/08" },
                    { new Guid("425ba7a0-8a64-4969-ac61-266e4cc15b7a"), "398", "1689608609376713", null, null, new Guid("d30c69b6-c3bb-4fb8-8db0-6868b777dc84"), "04/02" },
                    { new Guid("42a5433a-b374-4653-bf99-d15450eb70f1"), "685", "3390732416287375", null, null, new Guid("5447c5fe-3fa0-48b5-a17e-8250194941f0"), "04/13" },
                    { new Guid("42d29478-ecdc-42b7-863e-b3f10983516c"), "606", "8516075064281832", null, null, new Guid("03206cd0-0a83-4f1d-a4c3-c69cd723a833"), "09/27" },
                    { new Guid("42ed89b9-b00b-4d03-8b87-1012c19417b1"), "089", "7289365448682601", null, null, new Guid("f3705edc-b115-4663-a125-b50e5e1a8d61"), "12/20" },
                    { new Guid("433f0229-12c6-4b2d-9a97-bbcd1eecaf58"), "039", "6934075839265232", null, null, new Guid("6c41f334-a497-4ad3-b339-4f257df5e8a1"), "03/07" },
                    { new Guid("43832651-245a-4859-8c2e-9c8a794d0926"), "221", "4720839557308027", null, null, new Guid("cb7a8a7a-1a2f-4172-9641-73213dda6f27"), "04/28" },
                    { new Guid("46316aae-d0e4-4a9d-a38c-246b061d688e"), "281", "9351359585084744", null, null, new Guid("fc459777-d074-47f2-882b-cfb644e51153"), "09/18" },
                    { new Guid("4758c95a-7dd3-4eea-91e6-c93b28f2448c"), "892", "9157193508318280", null, null, new Guid("fb0896f7-6e43-466f-903f-b19063ef9b4e"), "07/11" },
                    { new Guid("47af0a7e-8b0b-420c-984f-f1dfbccbb657"), "075", "1911757039562549", null, null, new Guid("6ca12e95-3c92-4a88-b074-670e3a03e2ad"), "02/06" },
                    { new Guid("47cd87af-1bbc-4353-8a49-199a79bfad4d"), "635", "3318678797760498", null, null, new Guid("e89e4619-a828-4fc0-91c8-e3a676f37fd8"), "06/23" },
                    { new Guid("4863ba1a-2205-4c04-8e33-a855bccbbfdc"), "312", "7613275169997638", null, null, new Guid("6d3494e0-2538-4c40-a783-8ac4d7431186"), "05/20" },
                    { new Guid("488bcff2-7b5c-4a5d-ab37-8daf90177235"), "915", "1979903412138396", null, null, new Guid("32c3b50b-8cf7-4455-a8b1-8baea2a8672f"), "11/26" },
                    { new Guid("48969c21-ec44-4e6e-a60e-c9645c5da6b9"), "621", "1298859771318890", null, null, new Guid("83308a21-c0f0-4844-9a80-8f23d092f44d"), "08/03" },
                    { new Guid("48ef3dc4-55d5-4a62-898b-6daffee30d30"), "349", "9303677689760709", null, null, new Guid("9c165e41-013e-4021-8f91-3b83782c785b"), "11/24" },
                    { new Guid("48f4d117-db40-4923-95fb-0483d0dbf5d3"), "340", "2870088413252394", null, null, new Guid("aeb0382e-d0de-4c7b-81a2-0b0bfcb69e7c"), "03/24" },
                    { new Guid("4b046305-adb2-40ef-9ae9-c09c0421d51b"), "890", "4711513094076349", null, null, new Guid("53c328c6-20a9-4a3b-9139-0dc53eca45b9"), "05/20" },
                    { new Guid("4c394c91-8416-4697-b718-2710276153b8"), "818", "4858123694367234", null, null, new Guid("38ded439-45ec-480b-b66c-cd5cf711bc20"), "06/19" },
                    { new Guid("4e3cc7fb-1d75-4e41-8489-40afccb5b6bd"), "590", "2835231495450904", null, null, new Guid("e0fddf16-2ee8-4b1b-96fa-728043fc5fdb"), "06/19" },
                    { new Guid("4e6b0dd2-716a-4eb8-8fa4-8d296c4cd3c1"), "163", "1215548548128263", null, null, new Guid("f4833470-a758-4183-99bb-d6b2de8d76f3"), "11/21" },
                    { new Guid("4eab7b25-4655-4727-9e8b-c38882f1e84f"), "986", "3347061520437800", null, null, new Guid("d8398457-7807-4084-a625-1dcc46c8c95f"), "03/17" },
                    { new Guid("4f368c24-7f99-432b-84ec-4b5064acd18a"), "600", "8085652964808724", null, null, new Guid("5b8e8690-e89f-465e-b1f1-d1691e63b5a7"), "05/01" },
                    { new Guid("4f41b00a-8707-4009-93f5-28398ce3fdfd"), "665", "3694620810234782", null, null, new Guid("763309b3-5c69-4dd3-a486-d60fc8fb447f"), "04/24" },
                    { new Guid("4fe8bdc0-558e-4baa-b13d-45f4c9062056"), "758", "8892755194410287", null, null, new Guid("04783a93-a073-49ba-b314-9a9d07505a23"), "11/16" },
                    { new Guid("501e564b-8268-474a-8e24-9189b5fc72c2"), "360", "1218430860234802", null, null, new Guid("634d60aa-b959-4df2-80df-43de707c5d40"), "10/13" },
                    { new Guid("506654f5-0ad8-4fc5-8666-8aa540014724"), "035", "3492500606607369", null, null, new Guid("ed291a76-d17f-4119-9ae0-e51f2c416846"), "01/04" },
                    { new Guid("51f9b65b-1525-406c-8abe-ced3753443a5"), "174", "6469585285977363", null, null, new Guid("3a2f1601-ee3c-4dc7-94ae-150487ca9b0e"), "11/20" },
                    { new Guid("53aa8de8-6b30-4ceb-ad88-6ab71d6aad15"), "956", "4153876304152393", null, null, new Guid("1cfa453c-cf83-4679-8a13-c75e6a9abb9f"), "05/02" },
                    { new Guid("542ab4b6-66cc-43b5-96e9-1b8f44f82a85"), "192", "1514776007177453", null, null, new Guid("ab8e69e0-6bdd-4c58-aa72-b5d7b942a45c"), "04/14" },
                    { new Guid("556766d1-90f7-469b-bc4b-41a57c0cb795"), "423", "3297044438904760", null, null, new Guid("2b788029-2dc1-45b0-ae16-c6b7f8ae99cd"), "08/17" },
                    { new Guid("56ce5f09-8193-4fee-b56c-05af896a3841"), "496", "7755923152777735", null, null, new Guid("64c389e8-23ea-4152-b164-f47c8b7e14a4"), "05/25" },
                    { new Guid("577affda-b016-4e0b-8fd0-8bf785285be3"), "797", "3759184345924363", null, null, new Guid("d6cc8dd0-5158-4cdb-8023-0881d4e40a7f"), "10/06" },
                    { new Guid("57d806b3-5128-460b-8338-4ef4865ade3a"), "411", "6118225932036775", null, null, new Guid("3164cccf-16f3-43e3-9d84-bdf265d0f042"), "02/02" },
                    { new Guid("58087f8f-7f7e-411d-b833-4592174f065e"), "880", "7097660765512584", null, null, new Guid("11d33233-4672-4563-b05c-75adc34114d0"), "03/20" },
                    { new Guid("584a031e-c7c2-4c63-8a7c-9c59638b3c77"), "893", "2972171913068981", null, null, new Guid("e1789da4-c16d-474e-b5b7-e4ea2d7773e1"), "01/13" },
                    { new Guid("598e7059-69e5-411d-9134-4e2320ba1271"), "722", "2416765375570114", null, null, new Guid("5d5a349f-fc23-48b4-bb0d-17e4058591db"), "12/24" },
                    { new Guid("59d22e1e-de5b-49d3-b3c0-7d28cc6add70"), "327", "7407167599705818", null, null, new Guid("685bfb40-42a0-4e36-a25b-18f0594169cd"), "12/27" },
                    { new Guid("5a071f40-6fb1-4c61-ad5b-acef0bb577c3"), "133", "6210877782747801", null, null, new Guid("6d3494e0-2538-4c40-a783-8ac4d7431186"), "11/25" },
                    { new Guid("5a267c4b-82d6-487a-aa8b-e11a6c914170"), "177", "5275703636047649", null, null, new Guid("c40f7e4a-2697-484f-9169-40a60f67f790"), "05/04" },
                    { new Guid("5a3f11f1-b012-4b19-bc92-4d6e2028f633"), "516", "7949900916252896", null, null, new Guid("8e607f33-de9b-4ad8-840d-757d73ea219a"), "08/22" },
                    { new Guid("5a7a2752-3115-4b54-a45f-d7b8d9a413e5"), "451", "5167274226268087", null, null, new Guid("d8398457-7807-4084-a625-1dcc46c8c95f"), "05/20" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("5a7ba139-0985-4002-9a62-a5a5ab483265"), "284", "6627567049209036", null, null, new Guid("3fe9f50d-4c41-4652-a0f0-937333539e23"), "04/08" },
                    { new Guid("5b1d7ed5-7427-4720-9f78-cc8455a2ef56"), "581", "3861809949295948", null, null, new Guid("5cd7308b-03f8-4bf0-aa2f-bdb8009780b5"), "02/19" },
                    { new Guid("5be40112-40a2-471f-9421-cd0661343a2f"), "318", "9220426197873820", null, null, new Guid("becdf273-f038-4c47-ac9b-7ddd9f2e1e33"), "02/04" },
                    { new Guid("5c4038bd-aa72-4438-b749-934e7a2210fe"), "547", "1977677284538062", null, null, new Guid("6ab284a3-d8eb-4902-84a1-daa40cda75ff"), "11/02" },
                    { new Guid("5e4fa4a7-2ce5-4239-9984-a3bf292a08d4"), "889", "9047150449077619", null, null, new Guid("e1789da4-c16d-474e-b5b7-e4ea2d7773e1"), "10/19" },
                    { new Guid("5e66001d-baf3-4302-868d-b7f076393873"), "155", "3526631819530896", null, null, new Guid("81a84b38-10ae-4bdb-bc69-62d09049f2eb"), "02/12" },
                    { new Guid("5ec66886-f977-4f2e-8c9f-4bf6ea854ffe"), "188", "9764384299718545", null, null, new Guid("72dfada1-6c25-439b-947e-47044854ef32"), "05/18" },
                    { new Guid("5f4290be-bafb-4f9b-9504-5fe17768999d"), "652", "9747315847830496", null, null, new Guid("26733e03-7af8-4d51-b374-543ab6de1ac2"), "10/06" },
                    { new Guid("60ddb38c-7c12-4d24-a3b6-6a673cd69565"), "672", "8939721789358772", null, null, new Guid("72dfada1-6c25-439b-947e-47044854ef32"), "07/06" },
                    { new Guid("615000b7-933e-480b-8af5-aafab313390e"), "314", "8195713210339890", null, null, new Guid("3aad95ba-ed21-43ef-a29c-1f985c073977"), "06/15" },
                    { new Guid("617f4b48-62e3-41fb-acb4-0272dc17eff9"), "996", "5855905966127331", null, null, new Guid("a47332d0-0ead-49e5-8a17-c36abbe993cf"), "05/27" },
                    { new Guid("61bc9935-14c1-431f-a33d-3e0108551d70"), "131", "8460925689997167", null, null, new Guid("c8cd3068-cee0-4628-ad09-d40c8846af0e"), "08/13" },
                    { new Guid("6262bf99-ac96-43ad-b8fe-f7508d098141"), "080", "1378402527714757", null, null, new Guid("242f2320-4c8d-4696-b780-f7fb663444d7"), "11/07" },
                    { new Guid("653e7791-44ab-4ddd-9759-af02ee9aab5d"), "348", "2571075569167373", null, null, new Guid("8105c062-8cbb-4fd2-8bee-4f8676ba4c77"), "06/24" },
                    { new Guid("6653c9ff-69fa-4093-ac28-80215198c784"), "614", "5195402776664326", null, null, new Guid("14c01c35-5f30-4b72-b3ac-b488bcb95dd8"), "10/15" },
                    { new Guid("67df4d69-bc78-45f4-a1e4-63ec7a4f6615"), "477", "1079716350897897", null, null, new Guid("535d42b3-27a3-4778-83ea-bca31d19bc37"), "06/14" },
                    { new Guid("695cafa3-4716-4bc5-85c1-46b524d3d841"), "559", "3596502495722599", null, null, new Guid("e89e4619-a828-4fc0-91c8-e3a676f37fd8"), "11/12" },
                    { new Guid("69de354b-7c79-4159-81d8-c9b142e17c40"), "373", "1486637022848437", null, null, new Guid("68190cb1-10ca-4b5c-9498-fa81b7074af7"), "10/03" },
                    { new Guid("6a2bb7df-b74e-4149-929c-a03f3db83c39"), "210", "9271719541808100", null, null, new Guid("9eaac854-9360-4cfb-bba3-17af51a976dc"), "04/01" },
                    { new Guid("6bef853b-9da7-47e6-8537-ad2061fb05de"), "352", "2869868670559174", null, null, new Guid("8e589014-f1a8-4126-8752-f93955dda864"), "12/03" },
                    { new Guid("6c327f06-85b1-40d6-bd1c-759d2799ccef"), "692", "3548044686539487", null, null, new Guid("99597d95-3f59-40ef-a34e-d61ab094ab7e"), "12/23" },
                    { new Guid("6c64e67d-2414-4d0b-88e5-cf9000225c62"), "228", "2298133410479099", null, null, new Guid("d6cc8dd0-5158-4cdb-8023-0881d4e40a7f"), "07/02" },
                    { new Guid("6ee7972e-57e8-4070-a793-be23a616408d"), "886", "3650845889889219", null, null, new Guid("b3d5fc1e-b00e-4dc5-ba6d-73cbe178995d"), "08/04" },
                    { new Guid("6fe11f35-f899-477c-a31a-9ce26c350dfc"), "661", "9309417954294632", null, null, new Guid("8e826ea1-a328-453a-8c98-5ad120afa1b1"), "03/27" },
                    { new Guid("729c639c-3f28-4c5d-9dd3-233df32ad892"), "535", "6411401503530835", null, null, new Guid("011bfa78-8079-4b59-9a2b-bc6f6e829c86"), "10/27" },
                    { new Guid("72ab81b9-e6d4-4666-9ace-c0804cf54661"), "249", "6532471556514194", null, null, new Guid("dfa3d718-1b18-434d-ada4-1b7333c74185"), "03/10" },
                    { new Guid("7308257e-a0f3-4109-b5bd-20450fc15106"), "157", "4745659958015269", null, null, new Guid("8c4ec96b-048a-4caa-ad26-d2287c2cb425"), "09/24" },
                    { new Guid("735d77d8-27ff-43d3-8d47-0f338760c6dd"), "482", "2622949942975574", null, null, new Guid("94b1a2c9-02cb-40a3-a83c-fcbf54eeafcf"), "08/20" },
                    { new Guid("73e691d9-047e-4e4f-89cb-821f499150b8"), "682", "7327955625280700", null, null, new Guid("3b19b2ed-4bbc-4aeb-893c-751284547402"), "04/23" },
                    { new Guid("7429d6ec-7f64-4e74-af25-cb83d0a7e7e1"), "444", "7978229669106646", null, null, new Guid("a9f1eefe-7275-47ff-9e37-7ed1d62a4fc4"), "07/14" },
                    { new Guid("742da817-c6c0-469c-a1f4-cd6b3bd6568b"), "152", "4055051394996141", null, null, new Guid("8a351105-7a97-477b-b515-54d1920cf06c"), "09/23" },
                    { new Guid("74a13314-98ed-4cea-a9e5-e3cea5cb45bd"), "087", "2521601511016790", null, null, new Guid("94502636-bcc2-45b7-9c54-586c2d4ba805"), "04/11" },
                    { new Guid("75e06ba5-31a4-4a95-87c0-c6a5fe05d330"), "736", "9276062996694037", null, null, new Guid("f6c3a216-f660-4b3b-be8f-cffcc9647773"), "07/22" },
                    { new Guid("76ba13b8-1a6a-4e0e-ac94-823a0dc7c15a"), "293", "3873057140561891", null, null, new Guid("8e589014-f1a8-4126-8752-f93955dda864"), "09/11" },
                    { new Guid("77af34e1-9efc-4530-89fa-970726cc77b6"), "698", "7319815238969948", null, null, new Guid("38ded439-45ec-480b-b66c-cd5cf711bc20"), "01/07" },
                    { new Guid("78aedd7c-4760-476e-ae32-0f8f07d6bea2"), "626", "9044402605681429", null, null, new Guid("d46744dd-f7a6-44dc-9fba-85cb79426654"), "12/12" },
                    { new Guid("79158869-518b-4149-9b8c-e8489fd49c6d"), "570", "6205132288538264", null, null, new Guid("132b64b1-abc8-4e60-8d12-f59a86e35478"), "08/01" },
                    { new Guid("79ac2809-19a6-4ac6-9775-7b7d1eaec090"), "941", "5550826559981181", null, null, new Guid("ed291a76-d17f-4119-9ae0-e51f2c416846"), "02/19" },
                    { new Guid("79b19432-31ef-410c-bcb3-2a7839bbb574"), "757", "6514320810776901", null, null, new Guid("99597d95-3f59-40ef-a34e-d61ab094ab7e"), "09/28" },
                    { new Guid("7c748a41-f61b-4301-a37f-fe3c4323b9b3"), "042", "3669314733062178", null, null, new Guid("b78021d8-89d5-4707-8786-7fbca6c0a574"), "10/05" },
                    { new Guid("7e98c587-d1e6-49c4-97b3-9b4a6a94b6be"), "830", "6339025312359861", null, null, new Guid("7b51840b-3208-4d82-b7c3-d70a9d317d52"), "07/04" },
                    { new Guid("7ed4ecbc-5e16-439e-b9c9-6209544d4962"), "642", "5124657643407448", null, null, new Guid("d79bd932-238f-4d32-9f20-7df17e05ebb9"), "02/23" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("8040631e-97c4-42e6-bb4d-d6a0aaefca53"), "217", "9352644715699388", null, null, new Guid("d1479c7e-0b52-4900-a973-4c23cad398e8"), "10/03" },
                    { new Guid("807ce356-3cc4-4c96-bc4b-78c5f45d41eb"), "340", "6953747768119083", null, null, new Guid("669427c0-9731-4dd0-bf4e-5ffae835d749"), "02/09" },
                    { new Guid("84ba1eac-c949-49f4-bc14-d63f25fd8960"), "768", "6889927383129156", null, null, new Guid("03206cd0-0a83-4f1d-a4c3-c69cd723a833"), "01/18" },
                    { new Guid("8533bc9e-ec38-441a-bf0f-ec05c2703157"), "847", "1880553014717278", null, null, new Guid("24d43757-4120-44f4-94c2-ead9d5daddaa"), "05/22" },
                    { new Guid("8572de79-bf18-4690-9248-2a8081cf766a"), "040", "9804357172004104", null, null, new Guid("242f2320-4c8d-4696-b780-f7fb663444d7"), "10/06" },
                    { new Guid("8767319f-8625-422f-9a09-55c186140277"), "134", "4874474447844954", null, null, new Guid("4ae25a95-33f2-4b2d-81b6-219f34d42615"), "11/03" },
                    { new Guid("880e4dd7-5960-4007-80e6-4e18b465150c"), "534", "9931737794560484", null, null, new Guid("a22427e4-1bbe-46d6-8a35-e8b186eec051"), "04/10" },
                    { new Guid("88b4a1da-c210-44f4-aa0b-6fd5de1761a6"), "985", "5974227264824220", null, null, new Guid("54d641f7-2a06-4e4c-8299-945228d3d445"), "11/23" },
                    { new Guid("89629fb2-bfa4-493e-88a4-66b7dbd42f11"), "908", "9775462928911673", null, null, new Guid("61c06f70-126e-4167-8ea8-6f5345c1b219"), "09/26" },
                    { new Guid("8a8caeaa-4a65-41ad-941f-63edf646a3c1"), "055", "6439842654869614", null, null, new Guid("b731948f-baad-4203-a8a9-132fa96ff98a"), "11/16" },
                    { new Guid("8d5d5790-a7c6-486a-a559-4e2c2a44ee97"), "604", "5572305005226950", null, null, new Guid("8105c062-8cbb-4fd2-8bee-4f8676ba4c77"), "08/10" },
                    { new Guid("8e5ce7bf-b7cd-44b8-80e7-a08d6cff4139"), "798", "7631221767772915", null, null, new Guid("d1479c7e-0b52-4900-a973-4c23cad398e8"), "07/03" },
                    { new Guid("8eb9080f-9564-4409-b332-6e6adad2abd8"), "166", "9114678894706528", null, null, new Guid("58ac969d-fb5b-4674-8248-739bad1f3cc1"), "11/11" },
                    { new Guid("8faf2081-c8e1-4b21-9322-ec89bba9cb61"), "906", "6574812678572020", null, null, new Guid("c5058df5-0197-4f7a-93ba-70ba53810ad9"), "05/07" },
                    { new Guid("91cf8297-1721-4e39-a866-fd4876e20eb1"), "956", "1058954899118954", null, null, new Guid("5f2e044c-9c21-4457-bba7-8a8b2a3b8506"), "12/21" },
                    { new Guid("92310357-8026-4e71-96be-86a248d7b995"), "476", "8113835053662315", null, null, new Guid("81a84b38-10ae-4bdb-bc69-62d09049f2eb"), "03/28" },
                    { new Guid("928079af-9a48-487f-90b6-e73c5d6b9a56"), "652", "9590396711364209", null, null, new Guid("9733e81c-8e97-40c8-9dee-04c78313f7ba"), "06/10" },
                    { new Guid("93bc55a7-ee8b-4cff-a8ed-faab5f77b26b"), "942", "3468316672619448", null, null, new Guid("e4e5fb29-f257-4b37-aeb4-67e99ac407e2"), "12/03" },
                    { new Guid("942833c8-1c73-4f58-98cf-eb9178334fac"), "275", "9500091827402229", null, null, new Guid("7330d9a6-3b24-40c8-8897-1da54d2b22d3"), "01/28" },
                    { new Guid("9613bb0b-10ba-4ae6-82b0-0137ce38fd0d"), "261", "8381533166437228", null, null, new Guid("0940a8d8-dd0f-40bb-9d3a-06d4d77f7f76"), "04/21" },
                    { new Guid("96d43a4c-2974-4569-8d37-5497b891f5c4"), "502", "7224752283663707", null, null, new Guid("98f53e72-acee-45c0-ac25-6690ccdd4263"), "01/02" },
                    { new Guid("97abaaea-69a1-4820-861d-202036ff8a7b"), "322", "7719756568045920", null, null, new Guid("94b1a2c9-02cb-40a3-a83c-fcbf54eeafcf"), "06/03" },
                    { new Guid("99318def-0034-4f80-bbe0-4c29825d063a"), "256", "2080779844215957", null, null, new Guid("c4f5a5c9-bd9e-462d-b070-f3aaa07e0b8a"), "07/14" },
                    { new Guid("9a8592cc-4b63-47d6-9603-e2aee1257bdc"), "988", "6541416639686986", null, null, new Guid("6e5d52e0-6bc4-44c9-ad8d-3e771e7d1a31"), "06/06" },
                    { new Guid("9ba7b05b-72bb-41ab-b98c-f3a009f46bf0"), "143", "2666933771726654", null, null, new Guid("634d60aa-b959-4df2-80df-43de707c5d40"), "09/25" },
                    { new Guid("9be5c87d-a5a1-41c6-8edf-1f5ffcf8e257"), "646", "1568681187178447", null, null, new Guid("6c41f334-a497-4ad3-b339-4f257df5e8a1"), "07/27" },
                    { new Guid("a0b100d7-e11b-4f29-9804-0f410ff52304"), "766", "3782304109544110", null, null, new Guid("58ac969d-fb5b-4674-8248-739bad1f3cc1"), "03/17" },
                    { new Guid("a0dbfbf2-5315-4ee1-bd2a-a15173157512"), "131", "5436876152796230", null, null, new Guid("4ae25a95-33f2-4b2d-81b6-219f34d42615"), "11/07" },
                    { new Guid("a1710ba2-5445-4486-871c-9d04f8db4fd7"), "235", "7416522753283797", null, null, new Guid("8c9ecb5d-f75a-48f5-8f8a-aa87a39bf366"), "03/21" },
                    { new Guid("a2913b2e-d90e-40de-8321-55d9115692a1"), "793", "9162022848224679", null, null, new Guid("14c01c35-5f30-4b72-b3ac-b488bcb95dd8"), "11/13" },
                    { new Guid("a3a18562-fa66-4815-bbd6-a7771b292c79"), "144", "8427156290297017", null, null, new Guid("9fc79f69-d005-4692-b788-f9cfafc64432"), "01/08" },
                    { new Guid("a52b46c6-9652-4a44-9063-8f4f7330ca90"), "535", "6704649892357592", null, null, new Guid("32c3b50b-8cf7-4455-a8b1-8baea2a8672f"), "12/01" },
                    { new Guid("a5df0fe4-f6b0-4f8c-9c56-7ea5db33a938"), "686", "2267930830895404", null, null, new Guid("743a6ccb-c6b7-44b4-b2bc-815d0e1dbc57"), "03/01" },
                    { new Guid("a5e63c68-d660-41a7-ac23-cd1511a8f130"), "369", "1522329905128382", null, null, new Guid("e0b44f52-2c1b-4700-8955-8990365341f3"), "12/16" },
                    { new Guid("a615f278-96c2-4c2d-8eb5-f8e8562df660"), "033", "6114363928602087", null, null, new Guid("e1a64f4a-2d75-4d73-b7f3-c0bad04553b3"), "12/28" },
                    { new Guid("a702c5be-4a16-4723-af01-fa520aab61a1"), "732", "2923656073185101", null, null, new Guid("ea96a3ad-97ab-45a2-b388-ad8ae0678a64"), "09/11" },
                    { new Guid("a704eafd-bbc0-4756-a50d-8e56e17a7d7c"), "536", "6261834125772939", null, null, new Guid("c4fa5a9f-d66e-44a1-97d0-5345b88a261c"), "11/07" },
                    { new Guid("a77e0e8d-1fed-4120-a507-43921b1c78ad"), "863", "3538067082431623", null, null, new Guid("7330d9a6-3b24-40c8-8897-1da54d2b22d3"), "08/24" },
                    { new Guid("a7e5b1df-d772-4e03-8ab8-5015918bb57e"), "189", "9208754971254987", null, null, new Guid("1c7e7af7-236c-494b-99ee-f0360a4073ec"), "07/19" },
                    { new Guid("a9c6520f-cd0a-4806-b58f-81c0034462de"), "811", "7841009226892265", null, null, new Guid("30c2c88e-4d12-44b6-bf65-d7287b23f73a"), "05/26" },
                    { new Guid("ac8c88cb-f165-43b4-b550-6f02d0647fe8"), "567", "2902340856849558", null, null, new Guid("fb0896f7-6e43-466f-903f-b19063ef9b4e"), "10/22" },
                    { new Guid("ac8f2797-7a69-4796-8c47-e6f00220dc19"), "056", "5202023946156481", null, null, new Guid("693b0291-d9ec-4538-a406-714a496a19ae"), "05/06" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("ace10f99-469f-4e5e-aaae-0f01b432bafb"), "657", "6981122497130439", null, null, new Guid("620ac83c-2279-47b0-b848-78fdc8ca40bb"), "02/04" },
                    { new Guid("aeb3fc93-76b3-413e-a698-a0325f9370b3"), "928", "2161698816198180", null, null, new Guid("01b6209b-4724-4a1b-8ab1-22694a2927ac"), "10/04" },
                    { new Guid("aeec359a-811e-491e-a8f5-a4248273edd0"), "713", "9423605468068663", null, null, new Guid("66d925b4-240d-410f-8c2b-3699f28468c0"), "01/19" },
                    { new Guid("af424ea3-c018-41b4-b911-90f411c6b883"), "588", "4277175150825372", null, null, new Guid("b8a6b47e-6709-4c50-bef9-3ca557cdec75"), "01/02" },
                    { new Guid("af705590-094f-482c-bad3-3f2148103aa4"), "201", "6917718028675449", null, null, new Guid("3290441b-f700-4c29-8d43-fcfab150d3dc"), "11/28" },
                    { new Guid("affa6941-6d43-4172-ad69-4ae6d4e9a69d"), "273", "1763881639941388", null, null, new Guid("98f53e72-acee-45c0-ac25-6690ccdd4263"), "02/22" },
                    { new Guid("b07c3304-b04f-4a04-8662-2c6e085e5ea0"), "836", "1267548218371186", null, null, new Guid("743a6ccb-c6b7-44b4-b2bc-815d0e1dbc57"), "10/14" },
                    { new Guid("b128cbdb-3c0a-4fe6-8976-4fdc35f74b13"), "327", "3255733772955785", null, null, new Guid("b55f356e-5abf-4de3-90bb-651e00a33527"), "08/05" },
                    { new Guid("b1daac0a-3fc9-4bf0-8c21-c273f8c04bbd"), "135", "7427106837424574", null, null, new Guid("f3705edc-b115-4663-a125-b50e5e1a8d61"), "03/07" },
                    { new Guid("b251c1a4-6c08-4fb9-ba91-bbce6ecd660a"), "297", "6271173612505963", null, null, new Guid("3b227dd7-3231-42ef-9ca2-d488baa4ac37"), "01/23" },
                    { new Guid("b2dcd126-8cd6-4dbb-8914-bceadcf89543"), "478", "1693003745215156", null, null, new Guid("64927f99-7a49-4d79-bbb5-792b8fcce77d"), "02/08" },
                    { new Guid("b6003cc3-d157-4198-b39e-3b3d713d15f6"), "301", "5977533548950570", null, null, new Guid("ba84b45a-68b2-4f31-89e7-140a158d7c47"), "11/17" },
                    { new Guid("b66e6eec-334a-44cd-a3fd-ccc3cf772b9e"), "646", "8265647410659459", null, null, new Guid("620ac83c-2279-47b0-b848-78fdc8ca40bb"), "02/06" },
                    { new Guid("b68dae8d-bbfd-4caa-a219-d43e1bdce49c"), "297", "5870390978825045", null, null, new Guid("dfa3d718-1b18-434d-ada4-1b7333c74185"), "06/16" },
                    { new Guid("baa041d3-d7f7-4565-b6a1-04c8f274096c"), "392", "5920886101082836", null, null, new Guid("b3d5fc1e-b00e-4dc5-ba6d-73cbe178995d"), "03/27" },
                    { new Guid("baef2119-2a8b-4e40-888d-cd942197fbb0"), "270", "2167058702728091", null, null, new Guid("011bfa78-8079-4b59-9a2b-bc6f6e829c86"), "03/13" },
                    { new Guid("bafa8a28-cefb-4725-8114-d98bcc6ac9df"), "692", "5137139474330048", null, null, new Guid("64c389e8-23ea-4152-b164-f47c8b7e14a4"), "01/02" },
                    { new Guid("bc8cdd8c-04ee-4595-a1af-271cd7001e41"), "097", "5851411266671940", null, null, new Guid("9c165e41-013e-4021-8f91-3b83782c785b"), "12/27" },
                    { new Guid("bce3c740-25df-4569-8b12-40a0424f5662"), "692", "6658185672322263", null, null, new Guid("582c8883-3412-4ed7-98bb-b57fb389c528"), "09/24" },
                    { new Guid("bdd1d9ea-bf51-4509-a87b-cedb35231760"), "717", "9775973403170664", null, null, new Guid("5f2e044c-9c21-4457-bba7-8a8b2a3b8506"), "08/25" },
                    { new Guid("bdffc2fd-2b85-4eb7-98ec-4c327cbbcec0"), "198", "2470688250930842", null, null, new Guid("d79bd932-238f-4d32-9f20-7df17e05ebb9"), "05/20" },
                    { new Guid("be872a22-c777-47ce-ad8c-508d4ba244ba"), "773", "4598615495259909", null, null, new Guid("5cd7308b-03f8-4bf0-aa2f-bdb8009780b5"), "08/12" },
                    { new Guid("beebe635-822c-4722-bf7b-98b8046bbc1b"), "903", "2916528411164878", null, null, new Guid("4dde2dad-30f2-4b98-b6d2-313d1c90448a"), "02/19" },
                    { new Guid("bf84c43b-3301-4b7f-bb5d-bf917ac26fb6"), "104", "1604282529107030", null, null, new Guid("da7a4c19-d193-47c9-af19-28e8cf7e1cc3"), "07/11" },
                    { new Guid("c0076409-7e55-49c0-a844-f962fca8d058"), "839", "9549720589750037", null, null, new Guid("d46744dd-f7a6-44dc-9fba-85cb79426654"), "09/20" },
                    { new Guid("c0eff881-89e3-44f2-8195-6a414bd062a7"), "023", "3985308366361347", null, null, new Guid("6865f9d8-82f5-4c58-b134-366bbf5f73cd"), "07/09" },
                    { new Guid("c13f8c76-b598-4ff3-83ed-dfc3ebae2b2f"), "947", "8063453397979070", null, null, new Guid("2a14adef-3815-436b-8d13-7ce6f1a47256"), "04/02" },
                    { new Guid("c1746c64-23ba-4814-8547-ea9cd403920a"), "926", "1418087865059982", null, null, new Guid("4a156734-80e5-46c1-9184-e3de8106c414"), "07/16" },
                    { new Guid("c1ce2824-2384-40b8-b064-31342d4143d4"), "509", "3133608136677389", null, null, new Guid("bd25d5bd-6b10-46a7-a317-8be87004d57c"), "01/22" },
                    { new Guid("c30c8128-f9ed-45a9-ab06-044ff140ec54"), "513", "6545800544808790", null, null, new Guid("da7a4c19-d193-47c9-af19-28e8cf7e1cc3"), "01/07" },
                    { new Guid("c38e0079-9a6f-4a88-b450-31e69d63971a"), "494", "7269349514619802", null, null, new Guid("24d43757-4120-44f4-94c2-ead9d5daddaa"), "09/08" },
                    { new Guid("c3cd1eaa-6886-497d-9145-babae4d6c6fc"), "462", "5943264542944987", null, null, new Guid("8c9ecb5d-f75a-48f5-8f8a-aa87a39bf366"), "02/06" },
                    { new Guid("c3dd467e-657f-47f9-b6a5-014a3338320c"), "591", "9947555911061311", null, null, new Guid("94502636-bcc2-45b7-9c54-586c2d4ba805"), "05/25" },
                    { new Guid("c4279025-6084-440b-957a-76ec5a6dea09"), "289", "6004852992719442", null, null, new Guid("c4fa5a9f-d66e-44a1-97d0-5345b88a261c"), "05/19" },
                    { new Guid("c46c625a-9fc7-422b-8075-9241aa879401"), "549", "9801042049881072", null, null, new Guid("71406865-5477-4669-8982-3ba5171b622e"), "05/20" },
                    { new Guid("c529f078-430b-497c-8e72-17a26c36fafa"), "488", "8311372501843109", null, null, new Guid("bb37c6ac-6d15-402b-821c-b3cbae534856"), "04/05" },
                    { new Guid("c567c140-c309-421e-a76b-adbcd96ce614"), "910", "6645358713887292", null, null, new Guid("26733e03-7af8-4d51-b374-543ab6de1ac2"), "09/13" },
                    { new Guid("c5947dad-7f6b-4a0a-84c2-9e48047006c1"), "553", "5202892807568730", null, null, new Guid("9733e81c-8e97-40c8-9dee-04c78313f7ba"), "09/24" },
                    { new Guid("c5c97534-96f6-422c-a675-4b3d7f1a6ba2"), "021", "6947661401395359", null, null, new Guid("235130a9-9b51-4768-b9dc-39c124ecf778"), "10/08" },
                    { new Guid("c865f812-454b-4e20-a34c-b5e0f97d0835"), "836", "9149405721350680", null, null, new Guid("87ce0bee-feea-47c9-9746-0f0b2c6811a5"), "10/21" },
                    { new Guid("c9435bfd-66ed-4f9b-a327-3405c2a060f6"), "663", "3825652708927767", null, null, new Guid("e4e5fb29-f257-4b37-aeb4-67e99ac407e2"), "05/05" },
                    { new Guid("c965d851-27e7-4fba-8cc0-c2d6dfe38156"), "815", "8784247005462782", null, null, new Guid("fc459777-d074-47f2-882b-cfb644e51153"), "01/02" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("c97efdb7-0768-4b3d-88f3-604005f41400"), "059", "6463608959063279", null, null, new Guid("5bf3624b-e146-4dec-86a1-3c773763a4c6"), "02/11" },
                    { new Guid("ca79f4e7-2d8d-4a74-8683-687881555616"), "546", "2110057063201943", null, null, new Guid("bd25d5bd-6b10-46a7-a317-8be87004d57c"), "07/26" },
                    { new Guid("cb1d0ab7-755c-405d-b77b-ad368b664324"), "238", "3905067958196873", null, null, new Guid("a9f1eefe-7275-47ff-9e37-7ed1d62a4fc4"), "05/05" },
                    { new Guid("ccbafbcf-7be2-44ec-b362-37632754076c"), "396", "5068889589856677", null, null, new Guid("3290441b-f700-4c29-8d43-fcfab150d3dc"), "02/14" },
                    { new Guid("ce65f49b-7a33-40b1-a581-512e66750a04"), "654", "2701951334389988", null, null, new Guid("0940a8d8-dd0f-40bb-9d3a-06d4d77f7f76"), "06/10" },
                    { new Guid("cfd96459-9b30-4269-b0c8-c3da9291864b"), "757", "3271760525092443", null, null, new Guid("9f538d4b-1209-4cd8-b4f2-2f51bfea213a"), "11/05" },
                    { new Guid("d022a0b3-0497-4794-bd3d-33d553e35001"), "142", "2542321668625092", null, null, new Guid("cc34926c-ae68-4705-be47-32dccb133e04"), "11/05" },
                    { new Guid("d1088357-7bf9-49a0-95d3-2b9e6f0b2806"), "719", "1167805242018587", null, null, new Guid("b78021d8-89d5-4707-8786-7fbca6c0a574"), "08/27" },
                    { new Guid("d2fc1640-b3c7-4e0c-9cc7-0adca92127a5"), "254", "3682057378186572", null, null, new Guid("582c8883-3412-4ed7-98bb-b57fb389c528"), "09/16" },
                    { new Guid("d36f3da7-d1d8-4347-980c-518a26c7fbc0"), "830", "6178299349107760", null, null, new Guid("6506db45-d831-4985-a5fc-11c710625d57"), "08/01" },
                    { new Guid("d445b4fd-8bf2-4569-8606-d2740c0c31a1"), "142", "7333080355402679", null, null, new Guid("669427c0-9731-4dd0-bf4e-5ffae835d749"), "04/25" },
                    { new Guid("d5cbb557-0718-4d94-8d7c-17fb59316dc2"), "900", "7668396607873073", null, null, new Guid("de054994-8af5-427d-a0c9-9417c35b53e3"), "12/26" },
                    { new Guid("d74266be-016a-4aa0-9545-a0ffd2381583"), "774", "6968115613369136", null, null, new Guid("7f5da1b7-55fc-4da8-b92e-3e22ac562fdf"), "11/23" },
                    { new Guid("d78dee05-a0eb-4ce6-85f5-89d597049f7c"), "053", "5707935656059474", null, null, new Guid("9489d168-a4cb-4b13-bc18-9c899024ebf2"), "01/21" },
                    { new Guid("d952e549-dfa7-456b-a60d-ebaa30f52795"), "632", "5780864053530934", null, null, new Guid("3b19b2ed-4bbc-4aeb-893c-751284547402"), "09/25" },
                    { new Guid("dc2300e5-3e3e-4d4b-9d7c-fa3143581419"), "353", "4755560157641232", null, null, new Guid("7f5da1b7-55fc-4da8-b92e-3e22ac562fdf"), "10/22" },
                    { new Guid("dd61292d-199c-4214-aaba-4e02b2b13f05"), "544", "7923528434991790", null, null, new Guid("e0b44f52-2c1b-4700-8955-8990365341f3"), "05/09" },
                    { new Guid("dd8936e8-7ace-4a60-98bd-d875561c09d8"), "081", "1542252858180082", null, null, new Guid("763309b3-5c69-4dd3-a486-d60fc8fb447f"), "12/06" },
                    { new Guid("e2ecfac9-2a64-4fa7-9dc9-6a034369d975"), "219", "9204173545250220", null, null, new Guid("c8cd3068-cee0-4628-ad09-d40c8846af0e"), "06/08" },
                    { new Guid("e3873d29-28cc-48d2-9c1b-c736670c53b4"), "907", "9381437750908863", null, null, new Guid("7b51840b-3208-4d82-b7c3-d70a9d317d52"), "10/08" },
                    { new Guid("e41e4c78-d9a9-493a-bae7-6ce3fb5e5a47"), "709", "8475455014941941", null, null, new Guid("685bfb40-42a0-4e36-a25b-18f0594169cd"), "03/05" },
                    { new Guid("e4338e2e-896d-43dc-a500-e2f081aed89f"), "598", "5012816670635163", null, null, new Guid("30c2c88e-4d12-44b6-bf65-d7287b23f73a"), "08/12" },
                    { new Guid("e5d6b392-38fc-4fc9-b122-4de8711d424e"), "358", "6570314790689295", null, null, new Guid("b55f356e-5abf-4de3-90bb-651e00a33527"), "02/01" },
                    { new Guid("e5ebdd98-5505-4c58-9f83-defb5ff96acb"), "566", "3992692080482428", null, null, new Guid("db1c512a-6034-432f-bd76-96aa6ee64f05"), "05/21" },
                    { new Guid("e610aa3e-73b3-4c93-a8f9-2116f5a313b9"), "141", "4785037569603224", null, null, new Guid("3aad95ba-ed21-43ef-a29c-1f985c073977"), "12/24" },
                    { new Guid("e7771cb0-1e76-4b71-ae09-4c9b8d562f7b"), "039", "2503854845708363", null, null, new Guid("d18a9f4f-c9ff-487d-99c0-418797217186"), "07/25" },
                    { new Guid("e7ad4ffc-3f22-41ec-a18d-1d11d74da324"), "024", "6005637147146157", null, null, new Guid("9eaac854-9360-4cfb-bba3-17af51a976dc"), "03/24" },
                    { new Guid("e8937d1b-d8ba-40e8-9e22-d9a383945556"), "477", "7152326507143923", null, null, new Guid("66d925b4-240d-410f-8c2b-3699f28468c0"), "10/27" },
                    { new Guid("ea204834-aba4-4575-83b1-6ee1f0dfca4c"), "556", "3155056741613973", null, null, new Guid("025318b8-b68a-4350-ad23-a79900a71bf6"), "12/18" },
                    { new Guid("ec53c386-982f-4936-9162-630964a1dfa7"), "120", "1273415642980940", null, null, new Guid("132b64b1-abc8-4e60-8d12-f59a86e35478"), "05/09" },
                    { new Guid("ecee864f-40d5-4382-8598-fd412a8d467f"), "755", "7899261959016932", null, null, new Guid("6506db45-d831-4985-a5fc-11c710625d57"), "08/04" },
                    { new Guid("ed7bf36c-f388-4ad9-8424-c58ac3429261"), "577", "2675776902751848", null, null, new Guid("6ca12e95-3c92-4a88-b074-670e3a03e2ad"), "08/02" },
                    { new Guid("edf03f9d-c715-47ad-955e-47df01789ba3"), "522", "8251232154823362", null, null, new Guid("5792acc4-4f9f-4be4-9d2b-c8e60d69bc3d"), "10/26" },
                    { new Guid("ee20d8f1-13f5-497f-8a68-8546c566350b"), "118", "7480799666124710", null, null, new Guid("9489d168-a4cb-4b13-bc18-9c899024ebf2"), "04/16" },
                    { new Guid("ef8d07da-8a67-4dff-9832-4f56ce20761d"), "194", "3520279218286302", null, null, new Guid("e1a64f4a-2d75-4d73-b7f3-c0bad04553b3"), "05/11" },
                    { new Guid("f021ea6d-abbc-456e-ad68-0124b5f3e30b"), "749", "6669777391383031", null, null, new Guid("235130a9-9b51-4768-b9dc-39c124ecf778"), "11/24" },
                    { new Guid("f091c6e4-7d9f-440f-b5a1-64a35abd9869"), "103", "5847875794129502", null, null, new Guid("de054994-8af5-427d-a0c9-9417c35b53e3"), "01/27" },
                    { new Guid("f19d007d-f3af-4bc6-a0b3-d92375560457"), "519", "7031380869975757", null, null, new Guid("8e607f33-de9b-4ad8-840d-757d73ea219a"), "06/23" },
                    { new Guid("f286820c-b7b8-4d4c-b13a-b31278643947"), "648", "5345323627004410", null, null, new Guid("87ce0bee-feea-47c9-9746-0f0b2c6811a5"), "07/16" },
                    { new Guid("f414f50b-446e-48f3-8389-0071ced5e764"), "200", "1072757506375881", null, null, new Guid("c5058df5-0197-4f7a-93ba-70ba53810ad9"), "06/19" },
                    { new Guid("f460769e-4acb-4455-b722-7b5e1015e5e7"), "022", "6495543457856683", null, null, new Guid("54d641f7-2a06-4e4c-8299-945228d3d445"), "01/07" },
                    { new Guid("f499d330-ead9-47be-87de-464d3cef8fe2"), "758", "5620238926779647", null, null, new Guid("83308a21-c0f0-4844-9a80-8f23d092f44d"), "02/10" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "DateDeleted", "DateUpdated", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("f5e1a71e-23f7-4e72-9a5c-064740765f8a"), "481", "2068783714567031", null, null, new Guid("92de0b42-90fc-4112-958f-bed105500378"), "04/22" },
                    { new Guid("f6f9c6af-db3f-4837-83b0-f695e9038fa7"), "863", "1502595664753078", null, null, new Guid("5d5a349f-fc23-48b4-bb0d-17e4058591db"), "09/12" },
                    { new Guid("f729a117-28ec-4d4e-9a8b-c6a81c9fdaca"), "175", "7054284947169760", null, null, new Guid("c40f7e4a-2697-484f-9169-40a60f67f790"), "02/02" },
                    { new Guid("f8c632c6-cb1d-4c54-a714-91092788278e"), "712", "6459049906854998", null, null, new Guid("b195e0be-df91-40ed-a05b-d94ce9e97840"), "06/10" },
                    { new Guid("f93bd341-5105-426c-9a19-3c6cf0b2019b"), "469", "4727713235518773", null, null, new Guid("3b227dd7-3231-42ef-9ca2-d488baa4ac37"), "09/23" },
                    { new Guid("f9f200e0-b92d-424c-be8d-a1b78d0bb3f5"), "030", "4444344279071193", null, null, new Guid("5792acc4-4f9f-4be4-9d2b-c8e60d69bc3d"), "04/16" },
                    { new Guid("fa1d7aab-7de0-4bc4-9af2-b11b5e7671cc"), "722", "9837913938560256", null, null, new Guid("9f538d4b-1209-4cd8-b4f2-2f51bfea213a"), "05/22" },
                    { new Guid("fae7b1ae-b322-4e93-a343-09575ba506d5"), "522", "4394107088534916", null, null, new Guid("04783a93-a073-49ba-b314-9a9d07505a23"), "07/16" },
                    { new Guid("fd7fc8d9-77a4-4de7-a3bd-f707652e533e"), "608", "9952037390392902", null, null, new Guid("2a14adef-3815-436b-8d13-7ce6f1a47256"), "02/27" },
                    { new Guid("fe5be56c-03c2-4d03-863f-c92b8a4e6710"), "105", "1616144455415596", null, null, new Guid("b731948f-baad-4203-a8a9-132fa96ff98a"), "01/09" },
                    { new Guid("feb0ebda-a76b-4e92-9f1c-78c98b9ebf04"), "850", "8374345885269324", null, null, new Guid("ab8e69e0-6bdd-4c58-aa72-b5d7b942a45c"), "06/07" },
                    { new Guid("fedd90d4-6fbf-4043-958d-c27bdde21309"), "231", "2290860006695720", null, null, new Guid("4dde2dad-30f2-4b98-b6d2-313d1c90448a"), "04/21" },
                    { new Guid("fef060f2-1050-41de-9f4b-db5a5bd836eb"), "660", "7477778735921096", null, null, new Guid("71406865-5477-4669-8982-3ba5171b622e"), "12/25" },
                    { new Guid("ffe79245-c739-45c5-9d9c-0866a78de19e"), "864", "2115147730179570", null, null, new Guid("3a2f1601-ee3c-4dc7-94ae-150487ca9b0e"), "02/24" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("00ab9186-d9b4-410d-adb8-9ea262c419d6"), null, null, "+431 02 (763) 44-35", new Guid("cc34926c-ae68-4705-be47-32dccb133e04") },
                    { new Guid("019a683e-161c-4a1f-94be-27fb11c46090"), null, null, "+167 82 (668) 92-28", new Guid("5bedb553-aba5-4679-a39b-dd44adebf760") },
                    { new Guid("01e8372e-7bcb-48fd-a670-62d4db734be0"), null, null, "+689 57 (821) 20-98", new Guid("94b1a2c9-02cb-40a3-a83c-fcbf54eeafcf") },
                    { new Guid("03e70c0a-d065-41b8-aad1-de4d69e206ef"), null, null, "+197 84 (000) 85-96", new Guid("58ac969d-fb5b-4674-8248-739bad1f3cc1") },
                    { new Guid("03e92b9f-88f1-4795-9462-05ba2d4c4d04"), null, null, "+800 24 (729) 65-05", new Guid("f6c3a216-f660-4b3b-be8f-cffcc9647773") },
                    { new Guid("076dbee4-0db3-4914-a898-0ad442856a03"), null, null, "+171 73 (073) 45-61", new Guid("6c41f334-a497-4ad3-b339-4f257df5e8a1") },
                    { new Guid("08d05234-1c26-4a94-ac03-52d6bd7a4db5"), null, null, "+752 57 (152) 34-71", new Guid("5cd7308b-03f8-4bf0-aa2f-bdb8009780b5") },
                    { new Guid("091992b4-044a-4a3b-8da8-4b667c4b0987"), null, null, "+560 07 (345) 50-80", new Guid("d8398457-7807-4084-a625-1dcc46c8c95f") },
                    { new Guid("09bd6471-e1be-420e-beec-1743c2f8fafb"), null, null, "+153 10 (168) 16-40", new Guid("99597d95-3f59-40ef-a34e-d61ab094ab7e") },
                    { new Guid("09c310ee-f89f-47cf-992f-fa082d690c77"), null, null, "+453 34 (723) 09-57", new Guid("8e607f33-de9b-4ad8-840d-757d73ea219a") },
                    { new Guid("0a4fa7dc-45c9-46e4-b47b-5de4dd5c63eb"), null, null, "+756 57 (233) 73-65", new Guid("aeb0382e-d0de-4c7b-81a2-0b0bfcb69e7c") },
                    { new Guid("0b37897c-9f6c-4350-b4e3-e5c05ad1e9c3"), null, null, "+94 35 (388) 63-70", new Guid("d18a9f4f-c9ff-487d-99c0-418797217186") },
                    { new Guid("0b4bbf20-75a6-417c-9f93-e0fba6a3b4ed"), null, null, "+445 40 (577) 60-80", new Guid("5792acc4-4f9f-4be4-9d2b-c8e60d69bc3d") },
                    { new Guid("0bde3dce-b7cd-4622-be0d-0932470c2ebf"), null, null, "+283 22 (039) 54-54", new Guid("3b227dd7-3231-42ef-9ca2-d488baa4ac37") },
                    { new Guid("0caf0a4c-478f-4765-ae44-b53e089901b4"), null, null, "+603 44 (733) 77-77", new Guid("e0b44f52-2c1b-4700-8955-8990365341f3") },
                    { new Guid("0d687a3e-f440-451f-846c-97fec51cd7c5"), null, null, "+767 50 (198) 02-86", new Guid("30663ad5-6ea6-4216-9d1f-50ad24153778") },
                    { new Guid("0e02d73a-bb54-4b0f-a756-f83324b94e41"), null, null, "+282 15 (709) 21-13", new Guid("e4e5fb29-f257-4b37-aeb4-67e99ac407e2") },
                    { new Guid("0f26d4b0-15c7-41bd-99b9-26ef35575419"), null, null, "+558 78 (088) 44-95", new Guid("c8cd3068-cee0-4628-ad09-d40c8846af0e") },
                    { new Guid("0f8e1ff1-d0b6-43da-ac6d-44b0834a19b5"), null, null, "+210 16 (458) 29-89", new Guid("4ae25a95-33f2-4b2d-81b6-219f34d42615") },
                    { new Guid("10378b29-ca34-4407-9ef0-fe210871cec6"), null, null, "+136 70 (339) 30-10", new Guid("743a6ccb-c6b7-44b4-b2bc-815d0e1dbc57") },
                    { new Guid("108a911e-901c-45ca-9e5f-a0bb949e0220"), null, null, "+713 47 (772) 33-59", new Guid("87ce0bee-feea-47c9-9746-0f0b2c6811a5") },
                    { new Guid("11c3b174-dfdc-4490-8839-11e1379c753e"), null, null, "+924 43 (300) 77-98", new Guid("5d5a349f-fc23-48b4-bb0d-17e4058591db") },
                    { new Guid("11e46546-2375-4d42-9e23-babe2a501a90"), null, null, "+915 64 (347) 68-39", new Guid("6d3494e0-2538-4c40-a783-8ac4d7431186") },
                    { new Guid("13288e21-e963-49a5-a3bf-0aeaaa169759"), null, null, "+395 35 (533) 78-99", new Guid("f3705edc-b115-4663-a125-b50e5e1a8d61") },
                    { new Guid("132af927-262b-4bd8-9731-7974ee4055d1"), null, null, "+392 92 (631) 84-88", new Guid("634d60aa-b959-4df2-80df-43de707c5d40") },
                    { new Guid("141fe7ab-f979-4d4f-ad8e-db984b8a40d6"), null, null, "+873 34 (280) 39-67", new Guid("8a351105-7a97-477b-b515-54d1920cf06c") },
                    { new Guid("168966f8-8c1c-4d44-accd-2c07450d1afb"), null, null, "+126 34 (992) 77-16", new Guid("d8398457-7807-4084-a625-1dcc46c8c95f") },
                    { new Guid("16957964-9042-4583-8f51-21211ee5aa20"), null, null, "+475 91 (447) 77-52", new Guid("53c328c6-20a9-4a3b-9139-0dc53eca45b9") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("193c9c8c-4bcd-444f-93c5-161f494544d4"), null, null, "+390 15 (825) 60-92", new Guid("de054994-8af5-427d-a0c9-9417c35b53e3") },
                    { new Guid("1a1617f0-86df-4961-b991-97ac5dcbc31d"), null, null, "+555 44 (839) 12-17", new Guid("58ac969d-fb5b-4674-8248-739bad1f3cc1") },
                    { new Guid("1aea04c0-9149-4323-9d92-d725755bf48a"), null, null, "+575 27 (828) 38-41", new Guid("26733e03-7af8-4d51-b374-543ab6de1ac2") },
                    { new Guid("1b02a844-0fb5-4de7-b16c-8b43d1620ff4"), null, null, "+219 89 (412) 09-19", new Guid("becdf273-f038-4c47-ac9b-7ddd9f2e1e33") },
                    { new Guid("1c823ccb-ed6c-4f91-b049-fd1b23cbffc5"), null, null, "+888 37 (191) 14-48", new Guid("61f8f359-61ee-4cd6-a874-ed293b646ec2") },
                    { new Guid("1c933aa8-aba9-4fb0-9ba5-109a02ee1bb2"), null, null, "+748 08 (107) 35-65", new Guid("9eaac854-9360-4cfb-bba3-17af51a976dc") },
                    { new Guid("1e15e474-8f16-4bc7-bfa6-79b88d82775b"), null, null, "+779 36 (847) 90-95", new Guid("2b788029-2dc1-45b0-ae16-c6b7f8ae99cd") },
                    { new Guid("1e177c47-5028-4e2d-aee6-58e0ce72c746"), null, null, "+518 29 (926) 10-76", new Guid("99597d95-3f59-40ef-a34e-d61ab094ab7e") },
                    { new Guid("1eb4209a-595d-4964-86c7-f4563ff7f566"), null, null, "+3 11 (946) 00-55", new Guid("6ca12e95-3c92-4a88-b074-670e3a03e2ad") },
                    { new Guid("1ef236e7-53a0-4c49-8f45-fcb09034f5d0"), null, null, "+403 77 (908) 75-41", new Guid("1c7e7af7-236c-494b-99ee-f0360a4073ec") },
                    { new Guid("1fa56c52-2bcf-47ef-8fe8-071126c80a3d"), null, null, "+175 99 (629) 12-99", new Guid("a47332d0-0ead-49e5-8a17-c36abbe993cf") },
                    { new Guid("2043fb2a-637f-4274-9839-896c0d4a6b6a"), null, null, "+548 24 (806) 97-12", new Guid("5b8e8690-e89f-465e-b1f1-d1691e63b5a7") },
                    { new Guid("2157c1dd-bee2-4da5-9c3d-fd987f90a923"), null, null, "+736 44 (887) 72-92", new Guid("685bfb40-42a0-4e36-a25b-18f0594169cd") },
                    { new Guid("21975dd2-02b2-4ba1-96e5-38757ccb9391"), null, null, "+775 52 (220) 49-43", new Guid("68190cb1-10ca-4b5c-9498-fa81b7074af7") },
                    { new Guid("2226c995-d5ef-4435-a3ff-84fb858d1315"), null, null, "+193 83 (985) 65-66", new Guid("8e826ea1-a328-453a-8c98-5ad120afa1b1") },
                    { new Guid("23ed5913-88ed-401e-96b0-3a0d05e88cc8"), null, null, "+751 15 (846) 28-19", new Guid("6865f9d8-82f5-4c58-b134-366bbf5f73cd") },
                    { new Guid("245b8acf-5d6f-4439-8f00-47ccfc43a3bd"), null, null, "+255 68 (882) 67-11", new Guid("83308a21-c0f0-4844-9a80-8f23d092f44d") },
                    { new Guid("246cd056-7a80-41da-89db-c9c6595ad4fa"), null, null, "+895 06 (926) 65-59", new Guid("5cd7308b-03f8-4bf0-aa2f-bdb8009780b5") },
                    { new Guid("26ef8563-cee7-4020-aebf-f7b19ae9b575"), null, null, "+559 65 (748) 46-29", new Guid("3b227dd7-3231-42ef-9ca2-d488baa4ac37") },
                    { new Guid("26f16568-cc16-40ad-a050-d36d978721b3"), null, null, "+849 19 (023) 33-82", new Guid("a22427e4-1bbe-46d6-8a35-e8b186eec051") },
                    { new Guid("278dbec6-430b-4c0f-a121-796ceeb0452f"), null, null, "+899 44 (526) 96-88", new Guid("44de57c4-9c49-4a35-a564-3fc0727409b3") },
                    { new Guid("279f7cde-a09c-4e99-8a26-6c8df1066fcb"), null, null, "+4 27 (371) 70-70", new Guid("132b64b1-abc8-4e60-8d12-f59a86e35478") },
                    { new Guid("2837a848-0217-4786-9b28-1dee5cc88b56"), null, null, "+922 25 (684) 91-22", new Guid("4ae25a95-33f2-4b2d-81b6-219f34d42615") },
                    { new Guid("298020a9-9c97-44a5-8019-b6ec0f88fef7"), null, null, "+160 89 (902) 33-76", new Guid("535d42b3-27a3-4778-83ea-bca31d19bc37") },
                    { new Guid("2bdfb1a0-4e74-451f-b0cd-c9ab901dc97c"), null, null, "+239 07 (087) 93-53", new Guid("3a2f1601-ee3c-4dc7-94ae-150487ca9b0e") },
                    { new Guid("2c56d1ab-65a9-45a5-ab88-f6bc2dd540d4"), null, null, "+893 86 (911) 62-62", new Guid("e1a64f4a-2d75-4d73-b7f3-c0bad04553b3") },
                    { new Guid("2ca35503-2663-4881-b35c-4c5d34e553c6"), null, null, "+50 13 (590) 61-63", new Guid("5447c5fe-3fa0-48b5-a17e-8250194941f0") },
                    { new Guid("2d795087-d1d5-47fa-b0b5-8fe0a8796868"), null, null, "+338 51 (483) 78-33", new Guid("5f2e044c-9c21-4457-bba7-8a8b2a3b8506") },
                    { new Guid("2f845a6d-31d2-4990-8c30-7b42849534c9"), null, null, "+522 01 (088) 89-16", new Guid("72dfada1-6c25-439b-947e-47044854ef32") },
                    { new Guid("2fd75d11-910f-446b-9585-3289a8cd0c4e"), null, null, "+388 55 (854) 90-38", new Guid("81a84b38-10ae-4bdb-bc69-62d09049f2eb") },
                    { new Guid("31a2e8f1-5a31-4ab2-8132-78882a7603e7"), null, null, "+726 77 (900) 38-03", new Guid("582c8883-3412-4ed7-98bb-b57fb389c528") },
                    { new Guid("325fd226-846d-4c98-b83a-9ac661efe4ee"), null, null, "+822 84 (439) 27-97", new Guid("b195e0be-df91-40ed-a05b-d94ce9e97840") },
                    { new Guid("32ebcd00-406f-48c9-8c48-8b2025e72f6e"), null, null, "+167 73 (597) 72-67", new Guid("71406865-5477-4669-8982-3ba5171b622e") },
                    { new Guid("333fc4f2-e5ef-488a-af66-c79d4b5ac7b7"), null, null, "+528 41 (631) 92-85", new Guid("8105c062-8cbb-4fd2-8bee-4f8676ba4c77") },
                    { new Guid("337bad4e-dd7c-416a-bde4-b70337d830c4"), null, null, "+445 89 (648) 77-55", new Guid("01b6209b-4724-4a1b-8ab1-22694a2927ac") },
                    { new Guid("34b29dc3-0488-4a48-be45-6a1ddbdf3e31"), null, null, "+554 92 (782) 72-19", new Guid("8c4ec96b-048a-4caa-ad26-d2287c2cb425") },
                    { new Guid("34d46b34-4a51-4e16-9152-65ff091e650f"), null, null, "+586 97 (996) 34-50", new Guid("61c06f70-126e-4167-8ea8-6f5345c1b219") },
                    { new Guid("356687ab-a9cd-459e-9b90-02fe5daf8b7e"), null, null, "+261 81 (952) 30-89", new Guid("b3d5fc1e-b00e-4dc5-ba6d-73cbe178995d") },
                    { new Guid("35ff991d-7356-450b-afbf-2d43824cab1c"), null, null, "+667 22 (525) 60-24", new Guid("92de0b42-90fc-4112-958f-bed105500378") },
                    { new Guid("360c2bed-2fcd-4c79-aaac-d7cb54933e17"), null, null, "+831 52 (889) 19-39", new Guid("3b19b2ed-4bbc-4aeb-893c-751284547402") },
                    { new Guid("377e6150-7c5e-477f-b8e7-83ebcaa82034"), null, null, "+750 75 (750) 12-50", new Guid("5447c5fe-3fa0-48b5-a17e-8250194941f0") },
                    { new Guid("37fabf27-3fe6-4b3d-bc5e-80372285e065"), null, null, "+320 59 (896) 48-41", new Guid("64c389e8-23ea-4152-b164-f47c8b7e14a4") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("38c6180a-ca52-4800-af36-ad9da33a9d42"), null, null, "+983 55 (997) 50-59", new Guid("f3705edc-b115-4663-a125-b50e5e1a8d61") },
                    { new Guid("3a534631-a481-4c76-9034-b3459d641fa4"), null, null, "+81 64 (335) 51-17", new Guid("c8cd3068-cee0-4628-ad09-d40c8846af0e") },
                    { new Guid("3d647726-82ce-4782-9219-3c30346fa565"), null, null, "+242 65 (152) 16-82", new Guid("14c01c35-5f30-4b72-b3ac-b488bcb95dd8") },
                    { new Guid("3db599eb-3ead-4761-ad38-4e1584b2e004"), null, null, "+894 53 (607) 88-91", new Guid("9489d168-a4cb-4b13-bc18-9c899024ebf2") },
                    { new Guid("3dd4fba6-1476-4f2d-afe1-d915c940acfc"), null, null, "+772 33 (249) 00-89", new Guid("da7a4c19-d193-47c9-af19-28e8cf7e1cc3") },
                    { new Guid("3e4acb16-8be4-424f-add8-b58a92351003"), null, null, "+169 32 (577) 97-58", new Guid("3290441b-f700-4c29-8d43-fcfab150d3dc") },
                    { new Guid("3f1e3619-4d89-43d1-b76f-226b246b6dd7"), null, null, "+375 31 (971) 03-78", new Guid("7330d9a6-3b24-40c8-8897-1da54d2b22d3") },
                    { new Guid("3f4220d0-4d00-49fb-af91-a182d0fdfd96"), null, null, "+552 80 (295) 49-87", new Guid("fb0896f7-6e43-466f-903f-b19063ef9b4e") },
                    { new Guid("40cc0247-1b78-4274-8d15-78963442cc9e"), null, null, "+200 01 (116) 62-41", new Guid("669427c0-9731-4dd0-bf4e-5ffae835d749") },
                    { new Guid("4103a43f-b7b1-4c9c-a534-9c745edd0cd6"), null, null, "+468 00 (565) 80-66", new Guid("025318b8-b68a-4350-ad23-a79900a71bf6") },
                    { new Guid("430d8174-8f92-4e91-b7bd-aa941a7154b2"), null, null, "+219 94 (851) 28-37", new Guid("b3d5fc1e-b00e-4dc5-ba6d-73cbe178995d") },
                    { new Guid("431f83fc-a0d0-4e4d-a783-0b83aeaba17b"), null, null, "+684 19 (978) 44-60", new Guid("bb37c6ac-6d15-402b-821c-b3cbae534856") },
                    { new Guid("436ca4bb-7a18-4488-a0ab-9b6602a11cb5"), null, null, "+580 16 (427) 28-57", new Guid("4a156734-80e5-46c1-9184-e3de8106c414") },
                    { new Guid("452beea5-ef58-4877-bffa-8611ce1a5407"), null, null, "+852 09 (394) 95-28", new Guid("bd25d5bd-6b10-46a7-a317-8be87004d57c") },
                    { new Guid("46ffa1bf-4134-4660-9279-dbf516bc5323"), null, null, "+538 05 (672) 21-01", new Guid("b731948f-baad-4203-a8a9-132fa96ff98a") },
                    { new Guid("47156498-7f36-4665-a442-8435648f3901"), null, null, "+572 65 (431) 51-18", new Guid("bf1b0969-750b-4537-8f01-ac33cbe04263") },
                    { new Guid("489cf7f1-a479-4bda-a0a8-ccd87b30dc6a"), null, null, "+829 23 (578) 91-10", new Guid("6e5d52e0-6bc4-44c9-ad8d-3e771e7d1a31") },
                    { new Guid("4952e324-e073-4f18-91eb-cd0907f2dc68"), null, null, "+416 40 (389) 78-23", new Guid("14c01c35-5f30-4b72-b3ac-b488bcb95dd8") },
                    { new Guid("49747ac2-5dd7-41bb-bb18-2fb9d91b0701"), null, null, "+768 74 (949) 22-04", new Guid("64927f99-7a49-4d79-bbb5-792b8fcce77d") },
                    { new Guid("4af23b44-0cd2-46d4-887b-eeda9ec7dbf1"), null, null, "+714 85 (968) 98-50", new Guid("b8a6b47e-6709-4c50-bef9-3ca557cdec75") },
                    { new Guid("4c74c55e-7694-42c4-8124-49b838d202ca"), null, null, "+666 71 (268) 18-67", new Guid("db1c512a-6034-432f-bd76-96aa6ee64f05") },
                    { new Guid("4cb56d40-7529-4868-86bd-eb52d266fd1f"), null, null, "+320 00 (000) 15-69", new Guid("685bfb40-42a0-4e36-a25b-18f0594169cd") },
                    { new Guid("4e713d9e-fbbb-4439-9142-155094e11065"), null, null, "+426 77 (658) 54-70", new Guid("61c06f70-126e-4167-8ea8-6f5345c1b219") },
                    { new Guid("4eeb911d-069b-447f-978d-f171023c8b24"), null, null, "+830 85 (292) 73-44", new Guid("cb7a8a7a-1a2f-4172-9641-73213dda6f27") },
                    { new Guid("4ef89f17-4288-4da9-9c5f-9c8060c61fa5"), null, null, "+234 64 (172) 83-53", new Guid("ba84b45a-68b2-4f31-89e7-140a158d7c47") },
                    { new Guid("4f697eba-57b8-4e65-ac89-0028ec96fe8d"), null, null, "+832 78 (647) 96-84", new Guid("66d925b4-240d-410f-8c2b-3699f28468c0") },
                    { new Guid("4f9a981d-1e76-4fbd-bbe8-407198304aac"), null, null, "+684 97 (776) 31-72", new Guid("9733e81c-8e97-40c8-9dee-04c78313f7ba") },
                    { new Guid("50b48b6d-b68d-4b4a-a23c-f707640a9934"), null, null, "+118 64 (214) 68-66", new Guid("54d641f7-2a06-4e4c-8299-945228d3d445") },
                    { new Guid("514b6c86-ffe6-4449-aa94-97982eb2a337"), null, null, "+873 97 (167) 08-39", new Guid("235130a9-9b51-4768-b9dc-39c124ecf778") },
                    { new Guid("52670ef8-410b-4eb6-87f3-4f98bd3756a1"), null, null, "+130 96 (252) 29-92", new Guid("ab8e69e0-6bdd-4c58-aa72-b5d7b942a45c") },
                    { new Guid("52fc4f84-c373-47a7-a235-5e4aa240d850"), null, null, "+598 29 (233) 56-79", new Guid("11d33233-4672-4563-b05c-75adc34114d0") },
                    { new Guid("531b2a2f-f07a-4140-98a7-d2038c3f8ed3"), null, null, "+243 86 (405) 58-26", new Guid("d6cc8dd0-5158-4cdb-8023-0881d4e40a7f") },
                    { new Guid("5406d1ac-1dff-4f4f-b38a-2d1af4946e6d"), null, null, "+394 88 (764) 94-31", new Guid("242f2320-4c8d-4696-b780-f7fb663444d7") },
                    { new Guid("54eb7f73-9974-49b9-b910-c2034e0f44cd"), null, null, "+338 93 (893) 69-99", new Guid("de054994-8af5-427d-a0c9-9417c35b53e3") },
                    { new Guid("55857acd-8388-4ca0-827d-ef3a09d22d89"), null, null, "+563 15 (032) 49-48", new Guid("98f53e72-acee-45c0-ac25-6690ccdd4263") },
                    { new Guid("56d4076b-7fd0-48d1-89cd-75f686ce8569"), null, null, "+450 24 (560) 47-51", new Guid("94b1a2c9-02cb-40a3-a83c-fcbf54eeafcf") },
                    { new Guid("5be49589-540b-419c-b104-5c33576e8b5c"), null, null, "+741 73 (352) 92-73", new Guid("4dde2dad-30f2-4b98-b6d2-313d1c90448a") },
                    { new Guid("5db35b3c-e3bc-4b0b-a9e6-aece3914e779"), null, null, "+540 10 (877) 90-25", new Guid("e89e4619-a828-4fc0-91c8-e3a676f37fd8") },
                    { new Guid("5e1b6a48-e01a-4cfc-93e4-94de77709be4"), null, null, "+966 79 (174) 67-92", new Guid("9489d168-a4cb-4b13-bc18-9c899024ebf2") },
                    { new Guid("5e8591b6-3741-43d3-96c0-77f797e257cc"), null, null, "+306 51 (619) 28-73", new Guid("cb7a8a7a-1a2f-4172-9641-73213dda6f27") },
                    { new Guid("5f3894f9-f1f5-4592-8bce-61a61f072705"), null, null, "+94 26 (459) 26-59", new Guid("94502636-bcc2-45b7-9c54-586c2d4ba805") },
                    { new Guid("5f855233-b017-483a-96d3-a85b6b989331"), null, null, "+888 96 (642) 94-59", new Guid("b731948f-baad-4203-a8a9-132fa96ff98a") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("60f48ca5-3fc1-4a32-b296-9e609707c8ab"), null, null, "+770 71 (810) 33-59", new Guid("6506db45-d831-4985-a5fc-11c710625d57") },
                    { new Guid("6123dc87-0872-486a-b400-41562e75bae9"), null, null, "+332 64 (831) 68-99", new Guid("693b0291-d9ec-4538-a406-714a496a19ae") },
                    { new Guid("64b5eca7-f5f7-4567-a11c-a5317da506ad"), null, null, "+73 10 (993) 56-42", new Guid("f4833470-a758-4183-99bb-d6b2de8d76f3") },
                    { new Guid("64e5c6d5-3ab4-4db2-ab03-d635fa73e782"), null, null, "+166 67 (550) 87-40", new Guid("30663ad5-6ea6-4216-9d1f-50ad24153778") },
                    { new Guid("65487cf2-3fb0-457d-bd36-863ca9164ee0"), null, null, "+163 56 (909) 55-82", new Guid("763309b3-5c69-4dd3-a486-d60fc8fb447f") },
                    { new Guid("6568b7fc-6fde-4fad-a5c3-8983c5e69a2a"), null, null, "+154 01 (994) 14-44", new Guid("f4833470-a758-4183-99bb-d6b2de8d76f3") },
                    { new Guid("658c67d7-a876-4d2f-b64a-8ce99f395fa4"), null, null, "+308 78 (001) 39-25", new Guid("a22427e4-1bbe-46d6-8a35-e8b186eec051") },
                    { new Guid("66227260-9f51-4dae-90ba-b047319fb519"), null, null, "+220 18 (627) 19-34", new Guid("6865f9d8-82f5-4c58-b134-366bbf5f73cd") },
                    { new Guid("66f61830-6dfd-4b17-9b7f-f87ff8c95330"), null, null, "+656 13 (271) 00-44", new Guid("4a156734-80e5-46c1-9184-e3de8106c414") },
                    { new Guid("68582134-3d03-43cb-9b44-39f5bb285291"), null, null, "+462 91 (027) 76-79", new Guid("2b788029-2dc1-45b0-ae16-c6b7f8ae99cd") },
                    { new Guid("688caadf-61d5-4c2e-98dd-ba1c40b35835"), null, null, "+134 39 (926) 67-16", new Guid("3fe9f50d-4c41-4652-a0f0-937333539e23") },
                    { new Guid("6a8e7a05-b357-4f62-a57f-bc7c80fa6b07"), null, null, "+852 72 (794) 21-43", new Guid("1c7e7af7-236c-494b-99ee-f0360a4073ec") },
                    { new Guid("6c62e1f0-d346-4283-9471-7bb91aa83a21"), null, null, "+803 16 (644) 60-58", new Guid("bd25d5bd-6b10-46a7-a317-8be87004d57c") },
                    { new Guid("6d0d93a7-50ff-433f-be44-bab2c9708f42"), null, null, "+704 58 (873) 71-25", new Guid("f6c3a216-f660-4b3b-be8f-cffcc9647773") },
                    { new Guid("6d384062-395e-4e7a-8b5d-7434e2ff9693"), null, null, "+884 74 (100) 40-02", new Guid("dfa3d718-1b18-434d-ada4-1b7333c74185") },
                    { new Guid("6d7f13d7-7979-4dda-a97b-75f79c6e1c89"), null, null, "+492 22 (153) 62-82", new Guid("bb37c6ac-6d15-402b-821c-b3cbae534856") },
                    { new Guid("6f06f652-aa07-4ed1-a6d5-cd26b75adc23"), null, null, "+154 81 (759) 36-44", new Guid("71406865-5477-4669-8982-3ba5171b622e") },
                    { new Guid("6f0a4904-cf27-4153-b03e-a640b4c284c5"), null, null, "+987 32 (109) 18-50", new Guid("ea96a3ad-97ab-45a2-b388-ad8ae0678a64") },
                    { new Guid("6f3994bf-970c-4ebd-9ff4-d9384f6a8a04"), null, null, "+137 48 (852) 56-91", new Guid("d1479c7e-0b52-4900-a973-4c23cad398e8") },
                    { new Guid("70056b30-5a6e-4530-8fc9-4e7aa854714b"), null, null, "+207 53 (350) 18-10", new Guid("ab8e69e0-6bdd-4c58-aa72-b5d7b942a45c") },
                    { new Guid("700ff163-f340-47ed-b288-dcaa1a32702b"), null, null, "+951 87 (558) 84-91", new Guid("d30c69b6-c3bb-4fb8-8db0-6868b777dc84") },
                    { new Guid("7196a9fe-6680-494b-8b02-471863be595c"), null, null, "+655 03 (936) 62-44", new Guid("3164cccf-16f3-43e3-9d84-bdf265d0f042") },
                    { new Guid("7274be37-69c6-4495-a195-a5ce6e28b06e"), null, null, "+745 62 (370) 48-20", new Guid("81a84b38-10ae-4bdb-bc69-62d09049f2eb") },
                    { new Guid("72c116d5-2aca-4644-b93e-43e37d27fd0e"), null, null, "+364 36 (907) 72-39", new Guid("2a14adef-3815-436b-8d13-7ce6f1a47256") },
                    { new Guid("7316a717-1ff9-4b23-b6bf-ac232b14c4f2"), null, null, "+564 38 (753) 91-57", new Guid("7f5da1b7-55fc-4da8-b92e-3e22ac562fdf") },
                    { new Guid("75291eeb-7ed0-4b18-b166-b2f1dcd77955"), null, null, "+514 16 (118) 86-76", new Guid("3aad95ba-ed21-43ef-a29c-1f985c073977") },
                    { new Guid("7549982c-362c-43d4-b57a-4c95751f2d52"), null, null, "+83 69 (730) 62-29", new Guid("6d3494e0-2538-4c40-a783-8ac4d7431186") },
                    { new Guid("767ae4a8-0558-452d-b195-106b0457d0b6"), null, null, "+673 30 (328) 37-56", new Guid("763309b3-5c69-4dd3-a486-d60fc8fb447f") },
                    { new Guid("76e2203e-e6d9-4a12-ae3f-38e316525bf8"), null, null, "+190 43 (496) 89-43", new Guid("5d5a349f-fc23-48b4-bb0d-17e4058591db") },
                    { new Guid("78023602-35f1-4c0d-b942-dc14243cac8e"), null, null, "+769 16 (028) 04-93", new Guid("e1789da4-c16d-474e-b5b7-e4ea2d7773e1") },
                    { new Guid("789410b9-74a7-40b4-b45c-175b81c6e10d"), null, null, "+230 07 (635) 40-69", new Guid("a9f1eefe-7275-47ff-9e37-7ed1d62a4fc4") },
                    { new Guid("78c4ebcc-1ce3-44eb-8132-6d002344e9d6"), null, null, "+876 86 (779) 00-98", new Guid("693b0291-d9ec-4538-a406-714a496a19ae") },
                    { new Guid("7a062384-a905-461e-a8ec-b58eaac32ccc"), null, null, "+371 59 (252) 09-71", new Guid("fc459777-d074-47f2-882b-cfb644e51153") },
                    { new Guid("7b5feb94-ea06-471b-a3bd-b671e645f024"), null, null, "+424 55 (545) 68-25", new Guid("94502636-bcc2-45b7-9c54-586c2d4ba805") },
                    { new Guid("7be0ce02-908f-4f4c-8159-a2da8fce5b02"), null, null, "+400 31 (080) 33-31", new Guid("a9f1eefe-7275-47ff-9e37-7ed1d62a4fc4") },
                    { new Guid("7c70731e-0f0f-4a10-b0f8-9e8a4c0edf47"), null, null, "+502 44 (014) 30-63", new Guid("becdf273-f038-4c47-ac9b-7ddd9f2e1e33") },
                    { new Guid("7e2eec65-4aad-4198-be33-892a72c98075"), null, null, "+841 01 (068) 06-64", new Guid("44de57c4-9c49-4a35-a564-3fc0727409b3") },
                    { new Guid("7fbc0773-4813-4735-b7f1-f0a6c2ac8293"), null, null, "+452 43 (593) 32-78", new Guid("26733e03-7af8-4d51-b374-543ab6de1ac2") },
                    { new Guid("81fbe7a7-845b-43df-97d9-c5559957cf2a"), null, null, "+358 82 (457) 16-26", new Guid("d30c69b6-c3bb-4fb8-8db0-6868b777dc84") },
                    { new Guid("82930e20-a5ad-4c68-9f35-4f0b2227321b"), null, null, "+190 62 (611) 70-59", new Guid("ed291a76-d17f-4119-9ae0-e51f2c416846") },
                    { new Guid("835afd22-4f45-4161-a25c-0dfdaa7156f2"), null, null, "+963 87 (144) 44-48", new Guid("6506db45-d831-4985-a5fc-11c710625d57") },
                    { new Guid("8536eb07-464e-48ea-bc65-4eb56e3c55fa"), null, null, "+782 97 (239) 52-53", new Guid("7f5da1b7-55fc-4da8-b92e-3e22ac562fdf") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("85626f04-c1b9-4aa2-81ed-dd23c0c7c825"), null, null, "+657 94 (705) 45-94", new Guid("6ca12e95-3c92-4a88-b074-670e3a03e2ad") },
                    { new Guid("86544987-57c6-4404-9951-16311db9ae04"), null, null, "+610 16 (619) 92-02", new Guid("3a2f1601-ee3c-4dc7-94ae-150487ca9b0e") },
                    { new Guid("8673a9f7-6704-4543-a923-f396f8dd344b"), null, null, "+565 37 (159) 46-97", new Guid("4dde2dad-30f2-4b98-b6d2-313d1c90448a") },
                    { new Guid("86bece61-eb33-4072-9faf-60dfe2770d25"), null, null, "+922 43 (694) 24-67", new Guid("d6cc8dd0-5158-4cdb-8023-0881d4e40a7f") },
                    { new Guid("8787df98-b91d-448b-a59e-2c4696fc8da9"), null, null, "+723 46 (023) 98-23", new Guid("64c389e8-23ea-4152-b164-f47c8b7e14a4") },
                    { new Guid("8920d30b-11cc-4edd-88e4-eb4747c80894"), null, null, "+129 65 (314) 10-78", new Guid("6e5d52e0-6bc4-44c9-ad8d-3e771e7d1a31") },
                    { new Guid("893d9784-15fd-432d-930c-42502e83bc7b"), null, null, "+875 47 (661) 56-46", new Guid("620ac83c-2279-47b0-b848-78fdc8ca40bb") },
                    { new Guid("8a75a229-74f7-4a2b-a716-d37b453b0653"), null, null, "+351 83 (872) 06-54", new Guid("8c9ecb5d-f75a-48f5-8f8a-aa87a39bf366") },
                    { new Guid("8cedff48-5ea0-4853-bc14-af15c7713ede"), null, null, "+863 56 (439) 54-55", new Guid("cc34926c-ae68-4705-be47-32dccb133e04") },
                    { new Guid("8d5be9ef-8b2d-4ce2-8b8e-f692fc1493ee"), null, null, "+963 84 (460) 28-52", new Guid("235130a9-9b51-4768-b9dc-39c124ecf778") },
                    { new Guid("8f7fc7bc-d527-4485-ac72-99b111864b5d"), null, null, "+666 57 (720) 28-20", new Guid("24d43757-4120-44f4-94c2-ead9d5daddaa") },
                    { new Guid("8f851ba0-152f-4dee-b915-075492a3d924"), null, null, "+782 50 (554) 99-07", new Guid("64927f99-7a49-4d79-bbb5-792b8fcce77d") },
                    { new Guid("8f85df02-2af7-498d-9d3a-756437227882"), null, null, "+405 75 (393) 96-43", new Guid("03206cd0-0a83-4f1d-a4c3-c69cd723a833") },
                    { new Guid("908efa41-b467-4afa-843a-c8737eb6b255"), null, null, "+542 61 (912) 93-69", new Guid("6c41f334-a497-4ad3-b339-4f257df5e8a1") },
                    { new Guid("90fbe6b9-62f0-4090-8836-f444e3c69f3a"), null, null, "+240 92 (024) 86-33", new Guid("30c2c88e-4d12-44b6-bf65-d7287b23f73a") },
                    { new Guid("91e470dc-ea81-41c7-bbae-cd56c56b7f60"), null, null, "+951 87 (819) 92-59", new Guid("0940a8d8-dd0f-40bb-9d3a-06d4d77f7f76") },
                    { new Guid("91e58df0-94c5-4c20-add5-bf154755ec02"), null, null, "+804 18 (992) 02-93", new Guid("e0fddf16-2ee8-4b1b-96fa-728043fc5fdb") },
                    { new Guid("91fef006-1691-4e9e-99eb-a00595c15494"), null, null, "+744 34 (304) 40-74", new Guid("132b64b1-abc8-4e60-8d12-f59a86e35478") },
                    { new Guid("92a55d89-fc71-48b8-8726-6bdda193a5fe"), null, null, "+717 79 (876) 99-54", new Guid("011bfa78-8079-4b59-9a2b-bc6f6e829c86") },
                    { new Guid("93a35a88-aba6-436e-a989-f5c732b78740"), null, null, "+370 43 (964) 33-76", new Guid("b195e0be-df91-40ed-a05b-d94ce9e97840") },
                    { new Guid("95564ce0-9119-40b9-9108-9b026e58041b"), null, null, "+467 38 (861) 30-87", new Guid("dfa3d718-1b18-434d-ada4-1b7333c74185") },
                    { new Guid("96650047-25f9-4a04-b2c3-8cfc85b535fe"), null, null, "+185 53 (697) 97-64", new Guid("04783a93-a073-49ba-b314-9a9d07505a23") },
                    { new Guid("96fc32b2-eebe-449a-87b2-26608303ebc8"), null, null, "+446 17 (458) 17-13", new Guid("b8a6b47e-6709-4c50-bef9-3ca557cdec75") },
                    { new Guid("9749038e-2da4-4f72-aa68-f22ca8fc5b22"), null, null, "+495 48 (524) 94-59", new Guid("620ac83c-2279-47b0-b848-78fdc8ca40bb") },
                    { new Guid("9a251a4c-1144-4f0e-9190-cbe42d8722e2"), null, null, "+169 19 (789) 55-30", new Guid("53c328c6-20a9-4a3b-9139-0dc53eca45b9") },
                    { new Guid("9ba71bb9-2359-4161-8b90-9254b6d657e5"), null, null, "+574 15 (198) 75-34", new Guid("5792acc4-4f9f-4be4-9d2b-c8e60d69bc3d") },
                    { new Guid("9c283d74-b277-4617-9529-0c14658fa861"), null, null, "+679 40 (260) 78-88", new Guid("db1c512a-6034-432f-bd76-96aa6ee64f05") },
                    { new Guid("9e07a072-0c73-4f1c-af44-8971621e6895"), null, null, "+879 30 (796) 29-77", new Guid("3290441b-f700-4c29-8d43-fcfab150d3dc") },
                    { new Guid("a01f708a-4cbb-45b7-8244-3a075f9141f1"), null, null, "+741 07 (102) 93-45", new Guid("ed291a76-d17f-4119-9ae0-e51f2c416846") },
                    { new Guid("a09aeace-71d6-4626-ab00-8b5d7e0fbb3e"), null, null, "+841 96 (641) 88-06", new Guid("535d42b3-27a3-4778-83ea-bca31d19bc37") },
                    { new Guid("a0ca1f3b-b015-4062-9e01-f479b454c22d"), null, null, "+691 50 (031) 80-88", new Guid("c4fa5a9f-d66e-44a1-97d0-5345b88a261c") },
                    { new Guid("a3126073-5e06-4aa1-bb98-bbcd5faea4c6"), null, null, "+254 61 (670) 09-77", new Guid("11d33233-4672-4563-b05c-75adc34114d0") },
                    { new Guid("a475a846-708d-4bfe-a698-6cea840c3c5f"), null, null, "+15 21 (866) 44-07", new Guid("e0b44f52-2c1b-4700-8955-8990365341f3") },
                    { new Guid("a646098b-0a51-4e28-9f33-b88e39fc570f"), null, null, "+803 62 (719) 93-40", new Guid("30c2c88e-4d12-44b6-bf65-d7287b23f73a") },
                    { new Guid("a6d42e06-24db-404e-a76f-19a170811aa3"), null, null, "+675 32 (885) 34-65", new Guid("7b51840b-3208-4d82-b7c3-d70a9d317d52") },
                    { new Guid("a79410cc-667c-4072-9d83-ddccd5d3aa71"), null, null, "+826 20 (904) 95-23", new Guid("3fe9f50d-4c41-4652-a0f0-937333539e23") },
                    { new Guid("a9b91d9d-3c68-4489-97ec-40c4fc02aa41"), null, null, "+47 10 (420) 45-06", new Guid("fc459777-d074-47f2-882b-cfb644e51153") },
                    { new Guid("ab4e1cf5-a38f-441e-8c7a-f53f43d085f6"), null, null, "+139 19 (499) 45-53", new Guid("8a351105-7a97-477b-b515-54d1920cf06c") },
                    { new Guid("ab9ec14a-b947-4ee8-a80e-70bb8e6a91ac"), null, null, "+970 51 (957) 07-82", new Guid("582c8883-3412-4ed7-98bb-b57fb389c528") },
                    { new Guid("abb27f53-cd71-463a-acad-fb39f9736890"), null, null, "+104 09 (374) 77-68", new Guid("8e589014-f1a8-4126-8752-f93955dda864") },
                    { new Guid("acb2e158-4fcc-4ea8-8d3f-5003fcbde8dd"), null, null, "+522 57 (687) 35-88", new Guid("54d641f7-2a06-4e4c-8299-945228d3d445") },
                    { new Guid("acd15028-a924-4f51-a19b-0d3e8e0f41aa"), null, null, "+774 58 (218) 16-22", new Guid("c40f7e4a-2697-484f-9169-40a60f67f790") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("ad3d85f4-f695-4659-b81a-0062afcf8ea7"), null, null, "+937 69 (550) 41-54", new Guid("32c3b50b-8cf7-4455-a8b1-8baea2a8672f") },
                    { new Guid("af09591d-7c49-4cdc-a5f8-da771d99a50e"), null, null, "+862 41 (938) 34-20", new Guid("c4f5a5c9-bd9e-462d-b070-f3aaa07e0b8a") },
                    { new Guid("b0db8f95-c31d-40ab-a565-1d3075950ecb"), null, null, "+838 16 (033) 66-51", new Guid("6ab284a3-d8eb-4902-84a1-daa40cda75ff") },
                    { new Guid("b0f0383d-5886-4fe1-8272-469cbcad533a"), null, null, "+60 17 (079) 78-09", new Guid("011bfa78-8079-4b59-9a2b-bc6f6e829c86") },
                    { new Guid("b2bde33b-5341-440c-a330-aa3e6f7fce2c"), null, null, "+13 26 (306) 74-56", new Guid("5bf3624b-e146-4dec-86a1-3c773763a4c6") },
                    { new Guid("b40eeb81-60db-45a2-94b5-96b734b2baa1"), null, null, "+413 56 (902) 22-91", new Guid("61f8f359-61ee-4cd6-a874-ed293b646ec2") },
                    { new Guid("b4c962e8-2ca7-4960-976e-a8b77319aa83"), null, null, "+300 32 (810) 73-57", new Guid("669427c0-9731-4dd0-bf4e-5ffae835d749") },
                    { new Guid("b51c7f56-d0b4-4575-a013-67c0141c04fd"), null, null, "+271 98 (693) 37-33", new Guid("c5058df5-0197-4f7a-93ba-70ba53810ad9") },
                    { new Guid("b6728b93-3c7b-48d4-be80-a01f5ce6541e"), null, null, "+287 03 (992) 78-37", new Guid("8c9ecb5d-f75a-48f5-8f8a-aa87a39bf366") },
                    { new Guid("b6c82544-0474-4212-bfd8-d9ed86f5042c"), null, null, "+257 32 (611) 68-94", new Guid("2a14adef-3815-436b-8d13-7ce6f1a47256") },
                    { new Guid("b7b01807-4ea0-48ea-82d9-cc581bd4f0ce"), null, null, "+823 88 (179) 99-10", new Guid("8e826ea1-a328-453a-8c98-5ad120afa1b1") },
                    { new Guid("b83ae6cb-3541-4f41-9226-3e04e2d36f20"), null, null, "+14 15 (392) 74-89", new Guid("8c4ec96b-048a-4caa-ad26-d2287c2cb425") },
                    { new Guid("b9577906-73a7-4b30-9128-76debe79ab12"), null, null, "+237 08 (535) 72-13", new Guid("04783a93-a073-49ba-b314-9a9d07505a23") },
                    { new Guid("b9d9f4da-a933-463c-bf89-dcf4a8894a66"), null, null, "+840 20 (897) 67-34", new Guid("634d60aa-b959-4df2-80df-43de707c5d40") },
                    { new Guid("baac0eff-f3f4-4ac1-a0a4-d874d8d81864"), null, null, "+69 66 (776) 61-30", new Guid("e89e4619-a828-4fc0-91c8-e3a676f37fd8") },
                    { new Guid("bb629fbd-48e5-4894-895f-d174ceaaee62"), null, null, "+442 71 (020) 45-10", new Guid("9f538d4b-1209-4cd8-b4f2-2f51bfea213a") },
                    { new Guid("bc16c5ce-4850-4c56-a645-5e95414c643e"), null, null, "+655 30 (434) 23-84", new Guid("87ce0bee-feea-47c9-9746-0f0b2c6811a5") },
                    { new Guid("bd0e0527-779f-47c8-a118-c17316613bef"), null, null, "+549 52 (581) 05-23", new Guid("d46744dd-f7a6-44dc-9fba-85cb79426654") },
                    { new Guid("bd423845-68e7-47a6-a1b1-2687ac6861dc"), null, null, "+339 60 (048) 37-56", new Guid("3aad95ba-ed21-43ef-a29c-1f985c073977") },
                    { new Guid("be6d8d61-11a6-49df-809e-b2d73c1000fb"), null, null, "+951 44 (486) 90-92", new Guid("9c165e41-013e-4021-8f91-3b83782c785b") },
                    { new Guid("be83875a-d7b6-46e8-90fc-e69954bcc040"), null, null, "+305 83 (114) 23-60", new Guid("b78021d8-89d5-4707-8786-7fbca6c0a574") },
                    { new Guid("c45ec80a-5e5b-4572-901e-f32f566ac7e4"), null, null, "+43 24 (466) 77-68", new Guid("c4fa5a9f-d66e-44a1-97d0-5345b88a261c") },
                    { new Guid("c5ecd53a-1ef2-4d0e-8ee2-351597d37543"), null, null, "+200 10 (662) 04-62", new Guid("b001df7b-2cce-40f9-9c01-9b58f4ce2481") },
                    { new Guid("c6d38aea-d519-4edf-99fc-7d9e17b9cba1"), null, null, "+152 38 (002) 34-40", new Guid("66d925b4-240d-410f-8c2b-3699f28468c0") },
                    { new Guid("c7fd906e-df26-4dbe-941a-4b2769df4dbf"), null, null, "+828 04 (964) 14-50", new Guid("3164cccf-16f3-43e3-9d84-bdf265d0f042") },
                    { new Guid("c8426214-c03d-4f87-83d0-f5f17447c011"), null, null, "+994 37 (895) 87-99", new Guid("9fc79f69-d005-4692-b788-f9cfafc64432") },
                    { new Guid("c9c8a461-8064-4424-8f7f-df922367874c"), null, null, "+885 38 (815) 74-23", new Guid("ba84b45a-68b2-4f31-89e7-140a158d7c47") },
                    { new Guid("cabd1394-4165-4a8d-9017-9af75d763048"), null, null, "+371 28 (644) 31-76", new Guid("7330d9a6-3b24-40c8-8897-1da54d2b22d3") },
                    { new Guid("cb8d573c-c53c-4369-a5ed-e7587a7f0694"), null, null, "+749 26 (966) 79-25", new Guid("1ef52785-bff5-417e-bc0c-7f864cb6750b") },
                    { new Guid("cc19fffd-c0db-44bf-adf6-5937050f7e33"), null, null, "+595 66 (918) 76-95", new Guid("5bedb553-aba5-4679-a39b-dd44adebf760") },
                    { new Guid("cef14cfd-a81e-47ec-ab60-e3563ebd0117"), null, null, "+273 57 (833) 35-64", new Guid("32c3b50b-8cf7-4455-a8b1-8baea2a8672f") },
                    { new Guid("d20176f9-e91e-4f78-b3b4-b739536cc2af"), null, null, "+152 56 (486) 57-92", new Guid("1ef52785-bff5-417e-bc0c-7f864cb6750b") },
                    { new Guid("d28f355b-50e4-405d-9c66-641f9f24c2e7"), null, null, "+305 86 (540) 99-27", new Guid("e1789da4-c16d-474e-b5b7-e4ea2d7773e1") },
                    { new Guid("d326ebaa-9adf-4303-a797-7f892403d9a7"), null, null, "+925 99 (589) 95-10", new Guid("0940a8d8-dd0f-40bb-9d3a-06d4d77f7f76") },
                    { new Guid("d3a90eb5-abf1-4cb1-8b39-840e6a2b49fc"), null, null, "+977 90 (025) 81-11", new Guid("38ded439-45ec-480b-b66c-cd5cf711bc20") },
                    { new Guid("d59a7ed7-db6c-48dd-a766-01f705095b50"), null, null, "+731 80 (440) 31-29", new Guid("a47332d0-0ead-49e5-8a17-c36abbe993cf") },
                    { new Guid("d73f8753-edd5-4c27-9a8f-6ae543469241"), null, null, "+638 23 (123) 13-33", new Guid("5b8e8690-e89f-465e-b1f1-d1691e63b5a7") },
                    { new Guid("d896066a-e946-4506-98ab-1def1827589f"), null, null, "+678 92 (122) 45-32", new Guid("025318b8-b68a-4350-ad23-a79900a71bf6") },
                    { new Guid("d8c9e764-d410-46e4-92cd-3492ffb387e2"), null, null, "+617 87 (545) 19-66", new Guid("72dfada1-6c25-439b-947e-47044854ef32") },
                    { new Guid("d900ee10-4e1b-4a3f-bd2f-82a6f0b4961f"), null, null, "+965 14 (949) 86-04", new Guid("8e607f33-de9b-4ad8-840d-757d73ea219a") },
                    { new Guid("d94abdb6-a1c5-40c6-bd96-94c834e0bfbf"), null, null, "+603 42 (172) 86-18", new Guid("d18a9f4f-c9ff-487d-99c0-418797217186") },
                    { new Guid("da2fbd0d-469f-4680-9ffd-1b7d88f4cecf"), null, null, "+979 19 (383) 98-03", new Guid("01b6209b-4724-4a1b-8ab1-22694a2927ac") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "DateDeleted", "DateUpdated", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("dc02f635-c996-4f60-8750-8f24d0a8c0bf"), null, null, "+143 91 (228) 88-29", new Guid("1cfa453c-cf83-4679-8a13-c75e6a9abb9f") },
                    { new Guid("dc85517b-fefe-465a-a810-931e671f99c2"), null, null, "+428 15 (815) 01-37", new Guid("6ab284a3-d8eb-4902-84a1-daa40cda75ff") },
                    { new Guid("dd86d798-5771-4625-bf6a-f94f27724af7"), null, null, "+559 54 (663) 74-20", new Guid("03206cd0-0a83-4f1d-a4c3-c69cd723a833") },
                    { new Guid("ded68eeb-bc4e-4038-9eb3-a79f3f460bd7"), null, null, "+110 35 (881) 48-64", new Guid("b55f356e-5abf-4de3-90bb-651e00a33527") },
                    { new Guid("e1e79f77-7450-4b56-83af-c7fec1f7bfed"), null, null, "+856 18 (536) 62-70", new Guid("b78021d8-89d5-4707-8786-7fbca6c0a574") },
                    { new Guid("e2032c25-0e33-44bf-bd4d-35a38319245a"), null, null, "+260 04 (923) 33-95", new Guid("c40f7e4a-2697-484f-9169-40a60f67f790") },
                    { new Guid("e2f68541-21a6-44a1-b487-0c95a770eaa5"), null, null, "+43 34 (424) 55-36", new Guid("b55f356e-5abf-4de3-90bb-651e00a33527") },
                    { new Guid("e32da08f-f041-4126-8dc6-89117736993e"), null, null, "+109 31 (585) 66-06", new Guid("aeb0382e-d0de-4c7b-81a2-0b0bfcb69e7c") },
                    { new Guid("e368715c-b8d1-4e5c-acd0-8ea85bef937b"), null, null, "+142 00 (279) 69-40", new Guid("92de0b42-90fc-4112-958f-bed105500378") },
                    { new Guid("e4170eb8-70cc-4cd2-9d58-15a8583503f5"), null, null, "+997 38 (951) 77-10", new Guid("8e589014-f1a8-4126-8752-f93955dda864") },
                    { new Guid("e4244925-a9e5-4e9e-8e69-cd4c96f4c8b9"), null, null, "+519 50 (612) 42-71", new Guid("d79bd932-238f-4d32-9f20-7df17e05ebb9") },
                    { new Guid("e5013e63-6a5a-4f02-bedf-d601d1a8e37b"), null, null, "+391 45 (825) 00-70", new Guid("9733e81c-8e97-40c8-9dee-04c78313f7ba") },
                    { new Guid("e653c2d5-2c16-4801-b1d6-aa238bcfe5e9"), null, null, "+355 84 (157) 45-36", new Guid("98f53e72-acee-45c0-ac25-6690ccdd4263") },
                    { new Guid("e6e6e2c2-2680-45bb-935d-a6aa1ee70fb7"), null, null, "+446 09 (203) 86-00", new Guid("3b19b2ed-4bbc-4aeb-893c-751284547402") },
                    { new Guid("e73311fc-77b5-404a-ad65-5d2e06fd148c"), null, null, "+679 96 (259) 89-77", new Guid("9f538d4b-1209-4cd8-b4f2-2f51bfea213a") },
                    { new Guid("e760102e-f243-4a12-ae29-f4885a62a2d3"), null, null, "+964 77 (503) 22-06", new Guid("8105c062-8cbb-4fd2-8bee-4f8676ba4c77") },
                    { new Guid("e7cd69b5-951e-4f46-b331-716d0fe4c8b7"), null, null, "+109 51 (661) 62-34", new Guid("e1a64f4a-2d75-4d73-b7f3-c0bad04553b3") },
                    { new Guid("e82fa3ed-5f7d-4c26-b791-304e25bec7db"), null, null, "+929 49 (661) 97-74", new Guid("fb0896f7-6e43-466f-903f-b19063ef9b4e") },
                    { new Guid("e86935cf-1fc1-45a7-bc37-3ae2e8fc603c"), null, null, "+774 63 (871) 37-36", new Guid("38ded439-45ec-480b-b66c-cd5cf711bc20") },
                    { new Guid("e8be0b52-75f3-4c3c-9e2d-91dae42f47a4"), null, null, "+364 81 (022) 12-83", new Guid("e0fddf16-2ee8-4b1b-96fa-728043fc5fdb") },
                    { new Guid("e930bd88-2eba-4868-bfaf-d05a21a1d863"), null, null, "+847 60 (010) 10-83", new Guid("9c165e41-013e-4021-8f91-3b83782c785b") },
                    { new Guid("ebd9d480-4d24-4e78-8376-7e0553359d85"), null, null, "+717 88 (344) 91-00", new Guid("242f2320-4c8d-4696-b780-f7fb663444d7") },
                    { new Guid("ec14be3d-7d58-4281-99b9-0422f27508f6"), null, null, "+156 36 (224) 11-66", new Guid("24d43757-4120-44f4-94c2-ead9d5daddaa") },
                    { new Guid("ee0844ae-fb7b-42de-8ebf-b01794fd1303"), null, null, "+569 42 (576) 97-50", new Guid("1cfa453c-cf83-4679-8a13-c75e6a9abb9f") },
                    { new Guid("ee0f5643-9130-413f-8652-5ecb5facf478"), null, null, "+391 54 (977) 61-04", new Guid("7b51840b-3208-4d82-b7c3-d70a9d317d52") },
                    { new Guid("ee92c914-ae30-4f32-9fca-813e41041cc0"), null, null, "+169 20 (253) 21-22", new Guid("68190cb1-10ca-4b5c-9498-fa81b7074af7") },
                    { new Guid("f2535df1-e483-43fc-816a-57bb08ce134c"), null, null, "+558 22 (291) 32-69", new Guid("b001df7b-2cce-40f9-9c01-9b58f4ce2481") },
                    { new Guid("f3d2472e-188e-4a69-896a-da6d2ae66092"), null, null, "+964 86 (835) 31-02", new Guid("c4f5a5c9-bd9e-462d-b070-f3aaa07e0b8a") },
                    { new Guid("f44caed0-437d-4e5f-af3d-978a4ea7c2d0"), null, null, "+873 06 (346) 61-80", new Guid("ea96a3ad-97ab-45a2-b388-ad8ae0678a64") },
                    { new Guid("f4e938ed-476d-4f4d-90f5-8a229626d74b"), null, null, "+60 46 (444) 70-49", new Guid("743a6ccb-c6b7-44b4-b2bc-815d0e1dbc57") },
                    { new Guid("f5ae52ad-7fdf-43bd-b23d-edd448b024d5"), null, null, "+820 17 (097) 10-12", new Guid("5bf3624b-e146-4dec-86a1-3c773763a4c6") },
                    { new Guid("f634688f-673a-442d-9a4a-280f1df8ecdb"), null, null, "+679 54 (556) 33-04", new Guid("bf1b0969-750b-4537-8f01-ac33cbe04263") },
                    { new Guid("f6bc6e28-0fba-40b8-84f0-951bbd780b50"), null, null, "+70 88 (181) 63-59", new Guid("c5058df5-0197-4f7a-93ba-70ba53810ad9") },
                    { new Guid("f6cdb998-4c29-41db-8ffd-0b2af9fbb9af"), null, null, "+48 82 (763) 39-36", new Guid("9eaac854-9360-4cfb-bba3-17af51a976dc") },
                    { new Guid("f70c10d5-e681-4611-9993-56ac2c8f8eb6"), null, null, "+852 59 (711) 24-97", new Guid("e4e5fb29-f257-4b37-aeb4-67e99ac407e2") },
                    { new Guid("f97a79a3-db1d-4ac3-bc08-1d42fd955475"), null, null, "+979 61 (928) 60-92", new Guid("d46744dd-f7a6-44dc-9fba-85cb79426654") },
                    { new Guid("f98a67e8-5d06-463d-acef-633d4e26a8df"), null, null, "+142 66 (736) 62-38", new Guid("da7a4c19-d193-47c9-af19-28e8cf7e1cc3") },
                    { new Guid("fcab5501-f57d-438b-aa00-d27ee5e2a9b8"), null, null, "+342 29 (761) 17-41", new Guid("9fc79f69-d005-4692-b788-f9cfafc64432") },
                    { new Guid("fe7636a4-9660-4a60-8407-ce598e361c0a"), null, null, "+323 45 (823) 89-35", new Guid("d79bd932-238f-4d32-9f20-7df17e05ebb9") },
                    { new Guid("ff1844a3-c2f5-411d-bf15-88c7cf0c14bb"), null, null, "+833 51 (024) 85-56", new Guid("5f2e044c-9c21-4457-bba7-8a8b2a3b8506") },
                    { new Guid("ff6d164f-abfd-4946-99af-6a5bb3e052ba"), null, null, "+354 58 (200) 81-90", new Guid("83308a21-c0f0-4844-9a80-8f23d092f44d") },
                    { new Guid("fff17839-2ad3-4b14-a903-d2f3d853af14"), null, null, "+559 77 (801) 52-07", new Guid("d1479c7e-0b52-4900-a973-4c23cad398e8") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("006bc1fb-409b-4b1a-8767-ee41e4337846"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("01260b08-36ad-4cc1-83cc-cb8ced142113"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("0133e9e1-c218-4b5c-9018-5dea0908681b"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("01c437ed-3c87-4347-abac-a2423d8c4aff"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("03cb5331-1cde-47ff-abd7-f246ce312ed4"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("04db9828-1945-4b0d-918a-506978040ce2"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("05074228-8c26-4445-a9fd-b372d95a5f79"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("052f2d72-1647-4924-aa68-56b08a246ab1"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("058bcb19-571e-445f-9521-1caebd74ce61"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("05ebca08-7d36-4de6-8dce-ebbae09acde7"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("063fb510-cd4e-4c48-a6ad-918271eb45be"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("06ade50b-211d-4f5a-af52-ec9f33b929d5"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("08636941-b2bc-4023-bd9b-7d8c70199a12"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("0963477a-2fb5-4fb6-abd3-6adb5420ab5b"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("097a047c-db67-4420-8716-f01cd8e71e45"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("0aa17ff8-34a9-4ee3-99db-1eb6e6ade12d"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("0b47dae4-df1c-4d85-9f5e-66281df53b0d"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("0bfb1848-f80b-4b92-ad86-0b50f623a37a"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("0d37cd99-0e02-4836-bc45-a50f2086119e"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("0eef49e1-7bb9-44dd-8000-ee9454d250a9"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("0f5174a6-9c27-46db-8c34-6b0bae7b23b8"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("0f7f9d02-8db5-4528-95b4-aef410ae56bd"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("0fec5721-d800-4306-bca8-e5b0dcbcc2f4"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("10f1d668-754f-48ee-a756-7af01dc0026d"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("1158d5a7-1206-4bbd-98d9-cc4c48d18e10"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("119cceff-1e0f-420b-8ecc-b715123868e3"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("13246a24-4d79-4970-8b0b-8041e9ef8e0c"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("13938d28-ee07-412d-9198-0878ea30f4b7"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("14a8fc83-ed52-4dfb-abe5-a7086965993a"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("1594247d-251a-4b6d-8bdf-452857110086"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("17bca971-663a-429c-870a-65882e961742"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("17f4a106-fb84-4d63-80d3-17c6e57fc9c2"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("18080d4a-890e-41c3-8707-10eb2e31f212"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("180d336a-77e3-4585-849e-2aa9a6b32985"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("18b08ffc-7db4-4799-a454-34c2aa8ac235"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("195eadaf-fc49-4f58-930b-8a9232344b73"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("19ea3718-936a-4f32-a5be-cddfa1fcc20b"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("19f06bcf-3429-4a10-836c-c8c1023696c8"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("1cafce75-9269-4888-8cfb-dd606df13ff2"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("1d26659d-d6fb-408c-b025-61d68ad7aaa6"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("1ec077e2-3d62-496b-8c55-7e1546fcc476"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("20e4c862-c9b8-4857-aab7-1ea5d4601e7b"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("2191c6a6-f566-4a6b-9322-c5dc9799e16e"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("2373ef12-53cd-40d0-b301-7a79e406a52a"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("239596fe-d8d1-46ec-907f-63a14f0edcf2"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("239bd252-d7e6-4d16-89d4-8a60e8a4e786"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("24831af4-7062-4992-b0ad-f2bbb84b8951"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("256bd8f8-a1c1-489a-89c6-094d6759b5fb"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("28425c71-fc34-47ea-bc9c-25d5f75a48b1"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("28b6af6b-f163-4e3d-a402-700e09d5641b"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("29019f6f-39ce-4cf7-b75a-3063d8f440fc"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("2b0c835a-feb0-42f6-abaf-426b7d79af68"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("2d83f887-b75a-42d2-920d-de2b372cd59a"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("2ecdf581-612b-44a4-9592-3c347173e212"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("2fec396b-794a-4f37-8f00-83fff1563f9b"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("31a87889-3195-4fd1-9947-f6e52cb21806"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("32597353-89ea-4f5c-a4d2-0fad88d0f2a9"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("336a0e8f-04b1-4583-9058-3874b209752d"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("359c0d1e-1c12-4b71-a99a-77454a689250"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("35a1be76-d3d8-4f94-a5e6-3fda403e6a65"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("35f50e75-c058-4de5-b4b5-998ea38c9d80"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("3604f1d9-08a6-4dd6-afb9-c9ca742bb515"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("3606e286-fc99-483e-b018-1ae0e14d024c"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("36320294-3c98-479d-9f41-aa2304122aa0"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("36816255-3d80-4ba5-a838-b08a6846b3fd"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("3772e9ce-2a9d-45e2-a267-493db68f9661"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("3873bfc6-ae5e-4bc7-8bed-bd846386460b"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("3a7ba8bf-5001-4db1-8dec-b675061cf7e4"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("3a9e741c-bf36-47b3-ad14-f66214af2661"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("3b29bc38-56f6-4cde-8ee6-92f9c9d36485"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("3b4cd7e6-2c99-441a-91a3-3b9850d632d4"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("3bcf2d96-5c15-47e8-b60c-3a7095201cf3"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("3c4e5fc4-8b8e-49a8-9939-2f767a3d51ec"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("3ce64051-d47e-48af-ad7f-32a9250a47f3"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("3f65afd3-d1d6-415d-bb3a-9364db7df903"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("40b3b587-7feb-4a9c-b1d1-5425248f11cc"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("41331f52-70b7-4c2e-834e-787751aa16ed"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("42296111-27a8-41af-a0f1-10f0278003e5"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("43099ccd-5310-491f-b3c2-17db69c9fef0"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("4407e9c6-b853-4cd0-bfe6-e04e4b9d24c5"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("45aeccb7-7cd9-467e-9dba-0aa02725d964"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("45ca8924-1a92-4d47-b981-58311448e5b8"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("4689c324-37dd-440e-9c5e-99705420b767"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("4698b6df-1120-4b24-beca-7c130a43b173"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("47b67bb2-4184-40cd-a256-93b8091c0025"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("47e9d775-0234-4d4f-a133-6146301727c4"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("49e15c76-a16c-4643-9279-d315837f1387"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("4a51e0ed-3731-44d4-a27e-4bca857d902e"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("4cbd0d36-3a5d-4c0a-81bf-a4e446553cd5"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("4e4b4aaa-104f-4c20-abec-720f01d9e9ab"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("4fc94aef-74b5-4fe9-a169-dcd4c0242365"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("4fe76ae7-d3e9-4b37-8ed0-f38c828ce2b8"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("4fe8c152-cefb-4489-9c8e-0e6013bfce5a"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("50ce11a3-01f6-4c4e-9467-61e64352c4bb"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("516eeb4f-acdc-4e26-9e6f-76cda15059d6"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("51b74427-3803-4ec1-8803-71431f30a381"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("52a9df81-c5be-4593-8233-1b80c344f32d"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("530d57d5-eebf-4069-9676-3df7ad0ace48"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("530f0951-4372-4261-9003-f52af92cbac1"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("55e0a32d-2a22-45cd-bf74-12a53c9a0023"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("57523a4e-468b-42b3-8e2e-752d6db2a227"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("59b4ebf5-4b6c-406f-9193-53405bdb2ec4"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("5a5a17a1-6ddb-46a8-894b-4b056a6f0153"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("5aec82ea-071e-450e-a3d4-6f6b0f244726"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("5b7b3c5c-1bfb-4104-bdf1-c514f37daae0"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("5ca763e8-0a11-40e1-b3e6-75d0e1331758"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("5dcf5419-8d34-465b-8fe7-14e4d6e8ad8c"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("60e7c4c9-77fe-481d-a4b0-f8ffebac70cc"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("61394389-2b89-4a14-bf51-40c9eb89ad5e"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("6295ac75-b0c4-4742-b786-e3a40562a0ea"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("62afb63c-c59f-461f-ad46-a9f13ab94e1c"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("63607828-79d4-4279-b120-1b3ed1dacb92"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("6385fd1a-43d9-4b20-b702-a332e49fdde4"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("6679b6cb-3c2e-4170-a418-2d6965b7d9dc"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("66f1da7d-b77c-4a2a-b513-2b6006571123"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("67b01c6f-b7c1-4551-bd34-cca0fdffa616"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("68659f76-01f0-4531-b805-86d4e1044a02"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("6976f132-61d0-448e-bdaa-e7dddb5bceef"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("6b302c0c-5dc0-4e23-963e-eac941e65118"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("6bc7060d-cbbe-479f-901a-f63e4da4fc14"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("6be95aa0-6c7f-4535-a4f2-06579dedf388"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("6d249c47-9c30-4e17-b86a-af87513c9cd9"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("6ed29f62-2f03-4188-8b9b-92a2a510425e"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("6f8ec93a-f69a-43d4-8cf2-c62efaf972ae"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("7225caf7-4248-4cb7-9b60-65b774800c29"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("7248a013-0a12-47fe-8bbb-1287a9c8a6b5"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("7352d05c-e153-438d-863a-cb6e6546e479"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("7413f19d-7842-4009-8e71-d36760d82245"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("7442781a-0f41-440f-9b73-12b77857465f"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("74d48e9c-4e8f-4fe3-a531-50d1e1a6d7e4"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("75695c94-53e0-4021-a388-6869f6f751f1"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("75c82cc4-1ba9-4914-b472-77292eb27342"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("75ef2229-0350-4b68-b925-784cc1afc875"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("77d8c36e-cef2-48ec-a09b-71f85382e90c"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("7871209f-ba38-4dac-bf1c-bfa18f9eaadc"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("7ca0ce5d-7a8f-4adf-8f64-3d59f14da60c"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("7ca352a2-fb11-4275-ac3a-deef6d7c4b32"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("7d5dee53-c29d-4c66-bd10-58e10bf2ec40"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("804045e0-48a9-4a6d-a4fb-accf220bf6a1"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("8076be36-b95b-4335-b966-9d67b8e278a8"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("810aa958-6ce5-4bdc-9c49-e2d94cb22f23"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("81f076ba-a8c4-4b04-a477-04a7e3f5fb13"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("82f5962d-3e7a-4038-ae26-e2e800993d9a"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("82fe4cd6-41ee-47d5-acf7-a814a9598c79"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("838a44ef-956d-4984-8826-7aa14ffc3ed8"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("844246ed-203d-411d-b645-c846c87e91f2"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("85a9094b-4a00-4e37-aa68-b6ece0a8ed92"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("86739fa5-de4d-43a5-b26a-7a6c70b8c9fd"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("86cca152-ab57-4801-af64-718c77e9181c"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("86d43b87-868f-402d-9ba4-797bed15fd0a"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("87792505-cf95-42cf-ba81-d7f4f489735d"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("895e72b9-8b08-4aa4-a240-6f3d8e56dce1"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("8ae8f0bd-1360-45c2-b88a-63a76a23b910"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("8c041e8c-e1a6-4167-af7e-420f082d086b"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("8ce88f50-96f3-4a83-aa13-ddf269d05635"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("91f2a7a0-1c52-43c8-b72a-b6eb0b3310dc"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("92f2ca58-f9c7-4c14-9d04-5b8b6c0e2c87"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("931fd7db-dd58-43f1-8363-86d7b4c94152"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("932dd413-c26f-4980-8035-9b26e9dc96e5"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("93b59de1-2d72-4c0e-90f1-e880c53c9911"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("95632752-16fa-49e3-98d8-5909d8d698f1"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("96626ba7-cf29-4e7c-af13-4bc9cf4922f3"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("96a3494f-ec53-4517-b06a-ffcb0939da24"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("96b2c44f-e3a7-45bd-bf01-cd5b4705a3bf"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("96e67357-9195-4e91-b6d4-f529d5606913"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("97e30814-c907-4a9d-9bd7-928dd7bb501f"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("98349f00-79a2-459e-babd-8f3530df82a5"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("9902ea6c-72fb-4d27-8c47-62edfad7e983"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("99772c9d-d152-46e0-8df5-59acd58374a1"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("9ba15a44-2fea-4439-9b2e-c80d1569fa7a"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("9e611390-8c2b-41c3-a187-4cae2d2b46b2"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("9e9902af-0a51-46e1-8551-583d8e57f244"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("9ea6257e-6c48-4ea0-9c0a-620e1c5b83db"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("9ebbd20b-ef61-4823-82fc-eca61c31eaa0"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a07f5e0d-d8fd-45af-a505-607e2783347c"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a1475702-1aaf-48e4-a3db-54252a4faa9b"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a2ba2e29-7508-41d7-bb1e-e4bbdb502e1d"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a4a8925b-0c22-4a6d-a5b1-0b4530077098"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a5322fc3-30f7-408a-b39d-af79800e749f"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a5357889-82d8-41ae-aab7-1d33306e8ad4"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a556f617-8bdb-42bd-8b54-222a7b7aefb2"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a58a4c84-ba3b-4b1b-a99e-c2fa25d9e9a1"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a5fd894b-27a5-4b0d-9e79-5ff2128503ea"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a641ce2f-27c5-4b1d-ab7f-5ff0d3755f9d"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a74c6445-d598-452e-b006-ab343f9cfcd2"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a7cdad0b-f397-4909-9302-69bca5f70ece"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a7e7f98d-f8ec-4cca-a4f0-9a4b06d08424"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a7f38211-6cb6-4351-926d-9b34947f3eaf"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a890482c-1207-46db-a965-c0a2aa6ec49c"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a8cfc4da-1375-4797-b90f-925d580e4a68"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a8ddf3c7-c0ea-4879-8a3d-f8dd57eaa23b"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a942b88c-0a94-420f-9bff-0d05b658bd61"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("a958f6b7-9a9b-4c84-b0d6-c4de2ded2ce3"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("aa7365f2-0212-466e-8e34-fda2ec4b4aa8"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("ab0d8dc4-75d2-410c-ac64-ec728d8a2aa6"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("ab79b56c-7942-4037-9e96-a01cb23557b9"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("adb2c171-1539-4620-a28c-03498af90e4d"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("ae91e00a-6081-4f9b-bb27-f2f8602e2730"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("aec851c7-ea07-4505-9e57-a01dc5bd0826"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("b03330fb-63b7-476c-a4e1-a0d23c80d00d"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("b2e75b55-07cc-42fb-899d-20aa587d9fa1"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("b2f8ffa4-7b0b-441b-9e18-eebd18f1d05a"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("b368b277-a075-457e-8682-b61552f64bf4"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("b433a200-f650-4a53-9cd9-0dfbec421efa"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("b4baef71-97aa-4c83-b006-6860a654a382"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("b4d091e1-84a4-4eeb-acfd-cde9b886b838"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("b657ee87-4127-4585-80be-fbab5523cbae"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("b9837c96-77d2-49f3-b3c9-242b82ae0fee"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("b9c4d613-336e-457d-b910-ad58a437bd19"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("b9d9cfe6-4ce5-4a45-a09a-495a0a2ce4db"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("ba2301a1-6e53-47e8-af8e-2a290de38efc"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("baafba28-7fa0-4158-a35e-07831fb9ab13"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("badf80aa-f24d-4e7d-87ce-ec9d71d30aa4"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("bb059ab9-d962-4552-ab3c-eb9c64c398e7"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("bcf65c84-b55f-4cc7-a173-9ec67b3552d0"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("bd2377d4-c393-40dc-b4aa-708e044b62dd"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("bd9d79e8-f246-48eb-a136-1afa47d03eea"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("be22ad7e-70ab-4442-9341-9b0a1203d484"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("be529c4f-6e25-49b3-863c-a3865d1e68e0"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("be563eb4-181a-4316-82db-f7e7fb79e6a7"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("be780dd3-40b1-44d8-a28d-6ca3c7f9ef95"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("beecbf58-3e1a-4cf6-8c1f-dd7dbb915e17"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("c011f648-2e80-4953-b538-3967173ced6d"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("c0b394f5-f3b6-45d1-a4e1-1401ac5a7c94"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("c45eb81f-d2e6-439f-908d-21ae4afa7747"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("c4a4cf7d-acd8-4a37-b3cd-407bc60d73bf"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("c515cf9b-6ee2-4f27-8fb2-87ef9544ddfe"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("ca812928-261c-430e-b19e-f6f1f66d595d"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("cceead6c-7bb4-44bb-8d9b-dc36d148f41e"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("cd4e9448-17ca-4535-b32d-2b4241a3ca38"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("cdafd076-3fe9-4db6-8d51-439991cd4748"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("cdcecfc7-99c6-4f7f-bf00-484585336345"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("cf8281a7-b25a-4bf7-a7d3-ddb520433499"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("d1732425-f1d0-4399-8285-6fe122df5a4e"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("d2746aec-a1a2-4c18-b6e9-51047261a688"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("d2e4d25d-4400-4afe-ab19-f68313504e50"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("d3615e2d-b70e-4f08-ab8d-27aac6a0536c"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("d5101cea-30dd-4bf8-a506-ad59058bffb8"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("d6c30b9d-9c71-48a0-b406-3ded02cc9e91"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("d6d80dde-f066-477f-b83e-4ce716754ed3"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("d82c077a-bc31-424b-b303-88539565fd78"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("d8a53923-5192-49be-ba3c-0fd192a5bd5b"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("d8a6b53a-d985-4dbe-add0-95885ea135e1"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("d8c11cdd-6a9b-4751-8870-ff5a0d72c681"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("da10560a-c5d3-4aaa-9e9b-5da6d5a18e97"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("da44efe3-64b7-4298-845c-531d7028827d"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("db83849c-7962-4f39-8d13-7c88c513172b"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("dbd86844-1d09-4872-87e8-002dbd71dab9"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("dc5c05e0-ed9e-4f3f-945e-55ab42d659cd"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("df354f54-547f-4fba-b5aa-7f9c74bc697e"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("df7c723a-7890-48c7-a740-0e2998593d8c"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("e107a96c-b027-4b77-896e-fa64f510226f"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("e19910fd-8a9a-4e23-b251-25a30c675fcc"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("e2960a41-ae3d-443f-8684-20eb41a331e0"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("e5ceb199-74b3-4eff-aac3-1f2fffd71307"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("e977143d-65a7-459f-be29-7193f0530b1a"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("eaa003c3-e9cf-4cd4-8b54-92f086a38ba8"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("eaf6b157-b8f1-42cd-b488-d59c2244fe50"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("ebc41e40-cdb8-4dab-b8fc-472bcc58cb6e"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("ec1ad6c4-5edb-461d-9038-0843d3cc2df5"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("ec72b4f4-6ccf-403c-940e-3cc913202b60"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("ed54d146-5c94-4582-ace9-96ce95e68e86"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("ef96aa34-4dac-4829-9f67-0c2098b5ef4e"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("f04aee74-0bff-43f2-a530-32ae06c142c7"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("f21d33c5-3d1d-47a4-a929-af05c3488bae"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("f3f493b5-1028-4777-aee7-7ae089ebec2a"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("f44d7762-37cd-422d-8ba9-e220e10f1c7e"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("f4b10a8d-3127-42dd-942c-320a5c5d7968"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("f5673954-da3a-42fc-b74d-51a7dac3c23b"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("f8063816-6944-4f19-a734-c54c97376408"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("f836857d-dc2d-4b0d-9b8c-73a49703e2a5"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("f850063e-0cff-4df8-96d7-ad3fe11f08eb"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("f874d7ea-55a7-45be-a10c-12d379099e59"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("f988dd32-225e-46d8-b924-fa22ad2ddf81"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("fa94884b-1778-49c0-8df1-c30b0660f300"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("fb6f1bde-3089-48be-9d5b-130134be8353"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("fbe76579-fe8f-4e53-9a65-f9440629f9c2"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("fe8a598a-e240-424f-b2b8-2d3394704435"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("fed255f4-4060-46e2-be0f-086d314b76b8"));

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: new Guid("ffefe9e5-07f1-4ce3-ae26-9e3006484338"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("01abbe05-9ab6-4a2b-9d6a-a77510021322"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("04035955-21b3-4595-809a-af3efc212ec2"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("04aa0372-b2e0-4e34-b557-538473defcd7"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("053a2a47-08ba-421c-99a6-c153a4da5e94"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("068120c2-637e-4ba5-84a8-52de18559066"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("06943348-6143-47eb-b8e2-5a530b6563cc"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("06a96b62-b070-4b7a-a6e5-c6ddce4886ac"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("06fe96c4-a672-4ca7-99c3-27b9d355ed4c"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("07bbba69-e102-4b9b-b844-6238db2e2a64"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("0d304362-38e9-46a2-aa42-099e898415a3"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("0ee94d71-e2bd-407f-aa27-cf66d5312d4b"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("0f9fba47-4124-4a57-a470-2327efa14b7d"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("1077e0b9-e699-402c-91d2-ed129300a158"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("1086a2be-75f8-447e-a3a9-c6ef8269e917"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("11124270-9001-4393-a49b-b6ee663adbbd"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("132599e3-bc73-4640-a0cd-34981070e9af"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("1496faea-eb0d-44bc-a8c6-be52ba5abdf4"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("157642f6-d64b-4e44-847c-90fe75906554"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("1625abda-0657-405d-ac14-de0997c3ea13"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("1964bdde-704d-4ac7-8287-94e58e57c0a9"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("19b990e9-7ade-4b46-9e8c-236ca4378064"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("1a02d51e-6ac4-419d-8a74-7620be2e87f5"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("1b73a46c-b619-4d65-9cd1-b058b33d482b"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("1c132d97-449f-4cfd-b3c1-15ce04098c9c"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("1c5879cc-8478-4613-b74f-790173f5f578"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("1d7ce8d9-daa5-4a63-875b-05dab4dfaf26"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("1e1d9321-6476-4cd2-92a4-081ff0e0d007"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("1e267522-efb8-4760-8a09-1da4f5012c0c"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("1f2d59e5-0951-43b2-8311-b54d9532a627"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("1fc25c59-68b2-4d45-89b3-86321643a296"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("1fcfeb83-891f-4ba5-bf94-56a7c3b3ec46"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("1fe441d1-e07e-4677-becc-1106e142bcf9"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("2000484d-fa01-4632-9370-ee29715394d7"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("20be6dd6-76cc-4adb-b10e-09e129f12255"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("21309cdb-73a4-4908-bc6c-e47cc1a41d71"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("22355aa5-3faa-487b-bac6-361ba4cff78d"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("22c22703-287b-4a7f-a676-4c0a3247af70"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("26f3b475-c376-41a8-b8fb-6ee92e650eb2"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("27854bd7-2ca4-47ab-a323-1a162eb4f19c"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("294b3b3b-ed25-4947-9acc-3654a091ee68"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("2b3fdafd-dc5d-4d47-9314-27aeca73a0f5"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("2b6c0c6d-c7f7-4696-b13a-b656b83fde9a"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("2b6f6c2a-0481-4162-a734-04aac65c2dc0"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("2b75d1b1-94c9-4be9-8d2d-317244e58cf7"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("2bef1c0e-dca8-480b-bad0-c4891aa6adb2"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("2dd50163-2491-43a2-ac48-1e520cca37e4"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("2e8c6328-6237-4a72-a42a-587469d3a6e1"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("31410e3e-82c1-4fbd-976e-5c5225507b58"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("31914118-832a-4f4a-961a-1f3725f6f2c6"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("34b0e9f8-e825-4d11-8ae7-3b0c07954318"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("3693608e-79f2-4194-b84b-6197efc4e1aa"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("395fe650-fed1-4522-a805-2aa6c1833b07"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("3979d218-c690-47eb-8be6-cce3842ebd29"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("3a4a3bd3-8932-4f57-a545-6c73ad503e4e"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("3ac8e806-6e7a-4e14-aa46-d78ad77d79d4"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("3f31ee28-7b3c-49d5-aa06-e6ea55febc5f"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("3fed4c8a-1d77-420d-90b7-79f9ea0ae1fc"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("40f5d398-c753-4afd-b99e-0e835cb72775"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("425ba7a0-8a64-4969-ac61-266e4cc15b7a"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("42a5433a-b374-4653-bf99-d15450eb70f1"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("42d29478-ecdc-42b7-863e-b3f10983516c"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("42ed89b9-b00b-4d03-8b87-1012c19417b1"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("433f0229-12c6-4b2d-9a97-bbcd1eecaf58"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("43832651-245a-4859-8c2e-9c8a794d0926"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("46316aae-d0e4-4a9d-a38c-246b061d688e"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("4758c95a-7dd3-4eea-91e6-c93b28f2448c"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("47af0a7e-8b0b-420c-984f-f1dfbccbb657"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("47cd87af-1bbc-4353-8a49-199a79bfad4d"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("4863ba1a-2205-4c04-8e33-a855bccbbfdc"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("488bcff2-7b5c-4a5d-ab37-8daf90177235"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("48969c21-ec44-4e6e-a60e-c9645c5da6b9"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("48ef3dc4-55d5-4a62-898b-6daffee30d30"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("48f4d117-db40-4923-95fb-0483d0dbf5d3"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("4b046305-adb2-40ef-9ae9-c09c0421d51b"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("4c394c91-8416-4697-b718-2710276153b8"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("4e3cc7fb-1d75-4e41-8489-40afccb5b6bd"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("4e6b0dd2-716a-4eb8-8fa4-8d296c4cd3c1"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("4eab7b25-4655-4727-9e8b-c38882f1e84f"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("4f368c24-7f99-432b-84ec-4b5064acd18a"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("4f41b00a-8707-4009-93f5-28398ce3fdfd"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("4fe8bdc0-558e-4baa-b13d-45f4c9062056"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("501e564b-8268-474a-8e24-9189b5fc72c2"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("506654f5-0ad8-4fc5-8666-8aa540014724"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("51f9b65b-1525-406c-8abe-ced3753443a5"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("53aa8de8-6b30-4ceb-ad88-6ab71d6aad15"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("542ab4b6-66cc-43b5-96e9-1b8f44f82a85"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("556766d1-90f7-469b-bc4b-41a57c0cb795"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("56ce5f09-8193-4fee-b56c-05af896a3841"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("577affda-b016-4e0b-8fd0-8bf785285be3"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("57d806b3-5128-460b-8338-4ef4865ade3a"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("58087f8f-7f7e-411d-b833-4592174f065e"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("584a031e-c7c2-4c63-8a7c-9c59638b3c77"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("598e7059-69e5-411d-9134-4e2320ba1271"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("59d22e1e-de5b-49d3-b3c0-7d28cc6add70"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("5a071f40-6fb1-4c61-ad5b-acef0bb577c3"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("5a267c4b-82d6-487a-aa8b-e11a6c914170"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("5a3f11f1-b012-4b19-bc92-4d6e2028f633"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("5a7a2752-3115-4b54-a45f-d7b8d9a413e5"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("5a7ba139-0985-4002-9a62-a5a5ab483265"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("5b1d7ed5-7427-4720-9f78-cc8455a2ef56"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("5be40112-40a2-471f-9421-cd0661343a2f"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("5c4038bd-aa72-4438-b749-934e7a2210fe"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("5e4fa4a7-2ce5-4239-9984-a3bf292a08d4"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("5e66001d-baf3-4302-868d-b7f076393873"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("5ec66886-f977-4f2e-8c9f-4bf6ea854ffe"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("5f4290be-bafb-4f9b-9504-5fe17768999d"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("60ddb38c-7c12-4d24-a3b6-6a673cd69565"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("615000b7-933e-480b-8af5-aafab313390e"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("617f4b48-62e3-41fb-acb4-0272dc17eff9"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("61bc9935-14c1-431f-a33d-3e0108551d70"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("6262bf99-ac96-43ad-b8fe-f7508d098141"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("653e7791-44ab-4ddd-9759-af02ee9aab5d"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("6653c9ff-69fa-4093-ac28-80215198c784"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("67df4d69-bc78-45f4-a1e4-63ec7a4f6615"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("695cafa3-4716-4bc5-85c1-46b524d3d841"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("69de354b-7c79-4159-81d8-c9b142e17c40"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("6a2bb7df-b74e-4149-929c-a03f3db83c39"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("6bef853b-9da7-47e6-8537-ad2061fb05de"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("6c327f06-85b1-40d6-bd1c-759d2799ccef"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("6c64e67d-2414-4d0b-88e5-cf9000225c62"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("6ee7972e-57e8-4070-a793-be23a616408d"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("6fe11f35-f899-477c-a31a-9ce26c350dfc"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("729c639c-3f28-4c5d-9dd3-233df32ad892"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("72ab81b9-e6d4-4666-9ace-c0804cf54661"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("7308257e-a0f3-4109-b5bd-20450fc15106"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("735d77d8-27ff-43d3-8d47-0f338760c6dd"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("73e691d9-047e-4e4f-89cb-821f499150b8"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("7429d6ec-7f64-4e74-af25-cb83d0a7e7e1"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("742da817-c6c0-469c-a1f4-cd6b3bd6568b"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("74a13314-98ed-4cea-a9e5-e3cea5cb45bd"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("75e06ba5-31a4-4a95-87c0-c6a5fe05d330"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("76ba13b8-1a6a-4e0e-ac94-823a0dc7c15a"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("77af34e1-9efc-4530-89fa-970726cc77b6"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("78aedd7c-4760-476e-ae32-0f8f07d6bea2"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("79158869-518b-4149-9b8c-e8489fd49c6d"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("79ac2809-19a6-4ac6-9775-7b7d1eaec090"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("79b19432-31ef-410c-bcb3-2a7839bbb574"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("7c748a41-f61b-4301-a37f-fe3c4323b9b3"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("7e98c587-d1e6-49c4-97b3-9b4a6a94b6be"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("7ed4ecbc-5e16-439e-b9c9-6209544d4962"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("8040631e-97c4-42e6-bb4d-d6a0aaefca53"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("807ce356-3cc4-4c96-bc4b-78c5f45d41eb"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("84ba1eac-c949-49f4-bc14-d63f25fd8960"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("8533bc9e-ec38-441a-bf0f-ec05c2703157"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("8572de79-bf18-4690-9248-2a8081cf766a"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("8767319f-8625-422f-9a09-55c186140277"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("880e4dd7-5960-4007-80e6-4e18b465150c"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("88b4a1da-c210-44f4-aa0b-6fd5de1761a6"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("89629fb2-bfa4-493e-88a4-66b7dbd42f11"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("8a8caeaa-4a65-41ad-941f-63edf646a3c1"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("8d5d5790-a7c6-486a-a559-4e2c2a44ee97"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("8e5ce7bf-b7cd-44b8-80e7-a08d6cff4139"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("8eb9080f-9564-4409-b332-6e6adad2abd8"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("8faf2081-c8e1-4b21-9322-ec89bba9cb61"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("91cf8297-1721-4e39-a866-fd4876e20eb1"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("92310357-8026-4e71-96be-86a248d7b995"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("928079af-9a48-487f-90b6-e73c5d6b9a56"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("93bc55a7-ee8b-4cff-a8ed-faab5f77b26b"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("942833c8-1c73-4f58-98cf-eb9178334fac"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("9613bb0b-10ba-4ae6-82b0-0137ce38fd0d"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("96d43a4c-2974-4569-8d37-5497b891f5c4"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("97abaaea-69a1-4820-861d-202036ff8a7b"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("99318def-0034-4f80-bbe0-4c29825d063a"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("9a8592cc-4b63-47d6-9603-e2aee1257bdc"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("9ba7b05b-72bb-41ab-b98c-f3a009f46bf0"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("9be5c87d-a5a1-41c6-8edf-1f5ffcf8e257"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("a0b100d7-e11b-4f29-9804-0f410ff52304"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("a0dbfbf2-5315-4ee1-bd2a-a15173157512"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("a1710ba2-5445-4486-871c-9d04f8db4fd7"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("a2913b2e-d90e-40de-8321-55d9115692a1"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("a3a18562-fa66-4815-bbd6-a7771b292c79"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("a52b46c6-9652-4a44-9063-8f4f7330ca90"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("a5df0fe4-f6b0-4f8c-9c56-7ea5db33a938"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("a5e63c68-d660-41a7-ac23-cd1511a8f130"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("a615f278-96c2-4c2d-8eb5-f8e8562df660"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("a702c5be-4a16-4723-af01-fa520aab61a1"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("a704eafd-bbc0-4756-a50d-8e56e17a7d7c"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("a77e0e8d-1fed-4120-a507-43921b1c78ad"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("a7e5b1df-d772-4e03-8ab8-5015918bb57e"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("a9c6520f-cd0a-4806-b58f-81c0034462de"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("ac8c88cb-f165-43b4-b550-6f02d0647fe8"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("ac8f2797-7a69-4796-8c47-e6f00220dc19"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("ace10f99-469f-4e5e-aaae-0f01b432bafb"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("aeb3fc93-76b3-413e-a698-a0325f9370b3"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("aeec359a-811e-491e-a8f5-a4248273edd0"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("af424ea3-c018-41b4-b911-90f411c6b883"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("af705590-094f-482c-bad3-3f2148103aa4"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("affa6941-6d43-4172-ad69-4ae6d4e9a69d"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("b07c3304-b04f-4a04-8662-2c6e085e5ea0"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("b128cbdb-3c0a-4fe6-8976-4fdc35f74b13"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("b1daac0a-3fc9-4bf0-8c21-c273f8c04bbd"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("b251c1a4-6c08-4fb9-ba91-bbce6ecd660a"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("b2dcd126-8cd6-4dbb-8914-bceadcf89543"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("b6003cc3-d157-4198-b39e-3b3d713d15f6"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("b66e6eec-334a-44cd-a3fd-ccc3cf772b9e"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("b68dae8d-bbfd-4caa-a219-d43e1bdce49c"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("baa041d3-d7f7-4565-b6a1-04c8f274096c"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("baef2119-2a8b-4e40-888d-cd942197fbb0"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("bafa8a28-cefb-4725-8114-d98bcc6ac9df"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("bc8cdd8c-04ee-4595-a1af-271cd7001e41"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("bce3c740-25df-4569-8b12-40a0424f5662"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("bdd1d9ea-bf51-4509-a87b-cedb35231760"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("bdffc2fd-2b85-4eb7-98ec-4c327cbbcec0"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("be872a22-c777-47ce-ad8c-508d4ba244ba"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("beebe635-822c-4722-bf7b-98b8046bbc1b"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("bf84c43b-3301-4b7f-bb5d-bf917ac26fb6"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c0076409-7e55-49c0-a844-f962fca8d058"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c0eff881-89e3-44f2-8195-6a414bd062a7"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c13f8c76-b598-4ff3-83ed-dfc3ebae2b2f"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c1746c64-23ba-4814-8547-ea9cd403920a"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c1ce2824-2384-40b8-b064-31342d4143d4"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c30c8128-f9ed-45a9-ab06-044ff140ec54"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c38e0079-9a6f-4a88-b450-31e69d63971a"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c3cd1eaa-6886-497d-9145-babae4d6c6fc"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c3dd467e-657f-47f9-b6a5-014a3338320c"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c4279025-6084-440b-957a-76ec5a6dea09"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c46c625a-9fc7-422b-8075-9241aa879401"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c529f078-430b-497c-8e72-17a26c36fafa"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c567c140-c309-421e-a76b-adbcd96ce614"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c5947dad-7f6b-4a0a-84c2-9e48047006c1"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c5c97534-96f6-422c-a675-4b3d7f1a6ba2"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c865f812-454b-4e20-a34c-b5e0f97d0835"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c9435bfd-66ed-4f9b-a327-3405c2a060f6"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c965d851-27e7-4fba-8cc0-c2d6dfe38156"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("c97efdb7-0768-4b3d-88f3-604005f41400"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("ca79f4e7-2d8d-4a74-8683-687881555616"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("cb1d0ab7-755c-405d-b77b-ad368b664324"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("ccbafbcf-7be2-44ec-b362-37632754076c"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("ce65f49b-7a33-40b1-a581-512e66750a04"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("cfd96459-9b30-4269-b0c8-c3da9291864b"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("d022a0b3-0497-4794-bd3d-33d553e35001"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("d1088357-7bf9-49a0-95d3-2b9e6f0b2806"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("d2fc1640-b3c7-4e0c-9cc7-0adca92127a5"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("d36f3da7-d1d8-4347-980c-518a26c7fbc0"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("d445b4fd-8bf2-4569-8606-d2740c0c31a1"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("d5cbb557-0718-4d94-8d7c-17fb59316dc2"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("d74266be-016a-4aa0-9545-a0ffd2381583"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("d78dee05-a0eb-4ce6-85f5-89d597049f7c"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("d952e549-dfa7-456b-a60d-ebaa30f52795"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("dc2300e5-3e3e-4d4b-9d7c-fa3143581419"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("dd61292d-199c-4214-aaba-4e02b2b13f05"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("dd8936e8-7ace-4a60-98bd-d875561c09d8"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("e2ecfac9-2a64-4fa7-9dc9-6a034369d975"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("e3873d29-28cc-48d2-9c1b-c736670c53b4"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("e41e4c78-d9a9-493a-bae7-6ce3fb5e5a47"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("e4338e2e-896d-43dc-a500-e2f081aed89f"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("e5d6b392-38fc-4fc9-b122-4de8711d424e"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("e5ebdd98-5505-4c58-9f83-defb5ff96acb"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("e610aa3e-73b3-4c93-a8f9-2116f5a313b9"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("e7771cb0-1e76-4b71-ae09-4c9b8d562f7b"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("e7ad4ffc-3f22-41ec-a18d-1d11d74da324"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("e8937d1b-d8ba-40e8-9e22-d9a383945556"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("ea204834-aba4-4575-83b1-6ee1f0dfca4c"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("ec53c386-982f-4936-9162-630964a1dfa7"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("ecee864f-40d5-4382-8598-fd412a8d467f"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("ed7bf36c-f388-4ad9-8424-c58ac3429261"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("edf03f9d-c715-47ad-955e-47df01789ba3"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("ee20d8f1-13f5-497f-8a68-8546c566350b"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("ef8d07da-8a67-4dff-9832-4f56ce20761d"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("f021ea6d-abbc-456e-ad68-0124b5f3e30b"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("f091c6e4-7d9f-440f-b5a1-64a35abd9869"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("f19d007d-f3af-4bc6-a0b3-d92375560457"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("f286820c-b7b8-4d4c-b13a-b31278643947"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("f414f50b-446e-48f3-8389-0071ced5e764"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("f460769e-4acb-4455-b722-7b5e1015e5e7"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("f499d330-ead9-47be-87de-464d3cef8fe2"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("f5e1a71e-23f7-4e72-9a5c-064740765f8a"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("f6f9c6af-db3f-4837-83b0-f695e9038fa7"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("f729a117-28ec-4d4e-9a8b-c6a81c9fdaca"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("f8c632c6-cb1d-4c54-a714-91092788278e"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("f93bd341-5105-426c-9a19-3c6cf0b2019b"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("f9f200e0-b92d-424c-be8d-a1b78d0bb3f5"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("fa1d7aab-7de0-4bc4-9af2-b11b5e7671cc"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("fae7b1ae-b322-4e93-a343-09575ba506d5"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("fd7fc8d9-77a4-4de7-a3bd-f707652e533e"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("fe5be56c-03c2-4d03-863f-c92b8a4e6710"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("feb0ebda-a76b-4e92-9f1c-78c98b9ebf04"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("fedd90d4-6fbf-4043-958d-c27bdde21309"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("fef060f2-1050-41de-9f4b-db5a5bd836eb"));

            migrationBuilder.DeleteData(
                table: "PaymentCards",
                keyColumn: "CardId",
                keyValue: new Guid("ffe79245-c739-45c5-9d9c-0866a78de19e"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("00ab9186-d9b4-410d-adb8-9ea262c419d6"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("019a683e-161c-4a1f-94be-27fb11c46090"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("01e8372e-7bcb-48fd-a670-62d4db734be0"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("03e70c0a-d065-41b8-aad1-de4d69e206ef"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("03e92b9f-88f1-4795-9462-05ba2d4c4d04"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("076dbee4-0db3-4914-a898-0ad442856a03"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("08d05234-1c26-4a94-ac03-52d6bd7a4db5"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("091992b4-044a-4a3b-8da8-4b667c4b0987"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("09bd6471-e1be-420e-beec-1743c2f8fafb"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("09c310ee-f89f-47cf-992f-fa082d690c77"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("0a4fa7dc-45c9-46e4-b47b-5de4dd5c63eb"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("0b37897c-9f6c-4350-b4e3-e5c05ad1e9c3"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("0b4bbf20-75a6-417c-9f93-e0fba6a3b4ed"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("0bde3dce-b7cd-4622-be0d-0932470c2ebf"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("0caf0a4c-478f-4765-ae44-b53e089901b4"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("0d687a3e-f440-451f-846c-97fec51cd7c5"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("0e02d73a-bb54-4b0f-a756-f83324b94e41"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("0f26d4b0-15c7-41bd-99b9-26ef35575419"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("0f8e1ff1-d0b6-43da-ac6d-44b0834a19b5"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("10378b29-ca34-4407-9ef0-fe210871cec6"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("108a911e-901c-45ca-9e5f-a0bb949e0220"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("11c3b174-dfdc-4490-8839-11e1379c753e"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("11e46546-2375-4d42-9e23-babe2a501a90"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("13288e21-e963-49a5-a3bf-0aeaaa169759"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("132af927-262b-4bd8-9731-7974ee4055d1"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("141fe7ab-f979-4d4f-ad8e-db984b8a40d6"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("168966f8-8c1c-4d44-accd-2c07450d1afb"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("16957964-9042-4583-8f51-21211ee5aa20"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("193c9c8c-4bcd-444f-93c5-161f494544d4"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("1a1617f0-86df-4961-b991-97ac5dcbc31d"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("1aea04c0-9149-4323-9d92-d725755bf48a"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("1b02a844-0fb5-4de7-b16c-8b43d1620ff4"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("1c823ccb-ed6c-4f91-b049-fd1b23cbffc5"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("1c933aa8-aba9-4fb0-9ba5-109a02ee1bb2"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("1e15e474-8f16-4bc7-bfa6-79b88d82775b"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("1e177c47-5028-4e2d-aee6-58e0ce72c746"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("1eb4209a-595d-4964-86c7-f4563ff7f566"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("1ef236e7-53a0-4c49-8f45-fcb09034f5d0"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("1fa56c52-2bcf-47ef-8fe8-071126c80a3d"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("2043fb2a-637f-4274-9839-896c0d4a6b6a"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("2157c1dd-bee2-4da5-9c3d-fd987f90a923"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("21975dd2-02b2-4ba1-96e5-38757ccb9391"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("2226c995-d5ef-4435-a3ff-84fb858d1315"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("23ed5913-88ed-401e-96b0-3a0d05e88cc8"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("245b8acf-5d6f-4439-8f00-47ccfc43a3bd"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("246cd056-7a80-41da-89db-c9c6595ad4fa"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("26ef8563-cee7-4020-aebf-f7b19ae9b575"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("26f16568-cc16-40ad-a050-d36d978721b3"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("278dbec6-430b-4c0f-a121-796ceeb0452f"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("279f7cde-a09c-4e99-8a26-6c8df1066fcb"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("2837a848-0217-4786-9b28-1dee5cc88b56"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("298020a9-9c97-44a5-8019-b6ec0f88fef7"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("2bdfb1a0-4e74-451f-b0cd-c9ab901dc97c"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("2c56d1ab-65a9-45a5-ab88-f6bc2dd540d4"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("2ca35503-2663-4881-b35c-4c5d34e553c6"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("2d795087-d1d5-47fa-b0b5-8fe0a8796868"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("2f845a6d-31d2-4990-8c30-7b42849534c9"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("2fd75d11-910f-446b-9585-3289a8cd0c4e"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("31a2e8f1-5a31-4ab2-8132-78882a7603e7"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("325fd226-846d-4c98-b83a-9ac661efe4ee"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("32ebcd00-406f-48c9-8c48-8b2025e72f6e"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("333fc4f2-e5ef-488a-af66-c79d4b5ac7b7"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("337bad4e-dd7c-416a-bde4-b70337d830c4"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("34b29dc3-0488-4a48-be45-6a1ddbdf3e31"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("34d46b34-4a51-4e16-9152-65ff091e650f"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("356687ab-a9cd-459e-9b90-02fe5daf8b7e"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("35ff991d-7356-450b-afbf-2d43824cab1c"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("360c2bed-2fcd-4c79-aaac-d7cb54933e17"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("377e6150-7c5e-477f-b8e7-83ebcaa82034"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("37fabf27-3fe6-4b3d-bc5e-80372285e065"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("38c6180a-ca52-4800-af36-ad9da33a9d42"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("3a534631-a481-4c76-9034-b3459d641fa4"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("3d647726-82ce-4782-9219-3c30346fa565"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("3db599eb-3ead-4761-ad38-4e1584b2e004"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("3dd4fba6-1476-4f2d-afe1-d915c940acfc"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("3e4acb16-8be4-424f-add8-b58a92351003"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("3f1e3619-4d89-43d1-b76f-226b246b6dd7"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("3f4220d0-4d00-49fb-af91-a182d0fdfd96"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("40cc0247-1b78-4274-8d15-78963442cc9e"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("4103a43f-b7b1-4c9c-a534-9c745edd0cd6"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("430d8174-8f92-4e91-b7bd-aa941a7154b2"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("431f83fc-a0d0-4e4d-a783-0b83aeaba17b"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("436ca4bb-7a18-4488-a0ab-9b6602a11cb5"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("452beea5-ef58-4877-bffa-8611ce1a5407"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("46ffa1bf-4134-4660-9279-dbf516bc5323"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("47156498-7f36-4665-a442-8435648f3901"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("489cf7f1-a479-4bda-a0a8-ccd87b30dc6a"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("4952e324-e073-4f18-91eb-cd0907f2dc68"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("49747ac2-5dd7-41bb-bb18-2fb9d91b0701"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("4af23b44-0cd2-46d4-887b-eeda9ec7dbf1"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("4c74c55e-7694-42c4-8124-49b838d202ca"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("4cb56d40-7529-4868-86bd-eb52d266fd1f"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("4e713d9e-fbbb-4439-9142-155094e11065"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("4eeb911d-069b-447f-978d-f171023c8b24"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("4ef89f17-4288-4da9-9c5f-9c8060c61fa5"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("4f697eba-57b8-4e65-ac89-0028ec96fe8d"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("4f9a981d-1e76-4fbd-bbe8-407198304aac"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("50b48b6d-b68d-4b4a-a23c-f707640a9934"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("514b6c86-ffe6-4449-aa94-97982eb2a337"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("52670ef8-410b-4eb6-87f3-4f98bd3756a1"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("52fc4f84-c373-47a7-a235-5e4aa240d850"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("531b2a2f-f07a-4140-98a7-d2038c3f8ed3"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("5406d1ac-1dff-4f4f-b38a-2d1af4946e6d"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("54eb7f73-9974-49b9-b910-c2034e0f44cd"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("55857acd-8388-4ca0-827d-ef3a09d22d89"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("56d4076b-7fd0-48d1-89cd-75f686ce8569"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("5be49589-540b-419c-b104-5c33576e8b5c"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("5db35b3c-e3bc-4b0b-a9e6-aece3914e779"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("5e1b6a48-e01a-4cfc-93e4-94de77709be4"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("5e8591b6-3741-43d3-96c0-77f797e257cc"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("5f3894f9-f1f5-4592-8bce-61a61f072705"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("5f855233-b017-483a-96d3-a85b6b989331"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("60f48ca5-3fc1-4a32-b296-9e609707c8ab"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("6123dc87-0872-486a-b400-41562e75bae9"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("64b5eca7-f5f7-4567-a11c-a5317da506ad"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("64e5c6d5-3ab4-4db2-ab03-d635fa73e782"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("65487cf2-3fb0-457d-bd36-863ca9164ee0"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("6568b7fc-6fde-4fad-a5c3-8983c5e69a2a"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("658c67d7-a876-4d2f-b64a-8ce99f395fa4"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("66227260-9f51-4dae-90ba-b047319fb519"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("66f61830-6dfd-4b17-9b7f-f87ff8c95330"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("68582134-3d03-43cb-9b44-39f5bb285291"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("688caadf-61d5-4c2e-98dd-ba1c40b35835"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("6a8e7a05-b357-4f62-a57f-bc7c80fa6b07"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("6c62e1f0-d346-4283-9471-7bb91aa83a21"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("6d0d93a7-50ff-433f-be44-bab2c9708f42"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("6d384062-395e-4e7a-8b5d-7434e2ff9693"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("6d7f13d7-7979-4dda-a97b-75f79c6e1c89"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("6f06f652-aa07-4ed1-a6d5-cd26b75adc23"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("6f0a4904-cf27-4153-b03e-a640b4c284c5"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("6f3994bf-970c-4ebd-9ff4-d9384f6a8a04"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("70056b30-5a6e-4530-8fc9-4e7aa854714b"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("700ff163-f340-47ed-b288-dcaa1a32702b"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("7196a9fe-6680-494b-8b02-471863be595c"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("7274be37-69c6-4495-a195-a5ce6e28b06e"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("72c116d5-2aca-4644-b93e-43e37d27fd0e"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("7316a717-1ff9-4b23-b6bf-ac232b14c4f2"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("75291eeb-7ed0-4b18-b166-b2f1dcd77955"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("7549982c-362c-43d4-b57a-4c95751f2d52"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("767ae4a8-0558-452d-b195-106b0457d0b6"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("76e2203e-e6d9-4a12-ae3f-38e316525bf8"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("78023602-35f1-4c0d-b942-dc14243cac8e"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("789410b9-74a7-40b4-b45c-175b81c6e10d"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("78c4ebcc-1ce3-44eb-8132-6d002344e9d6"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("7a062384-a905-461e-a8ec-b58eaac32ccc"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("7b5feb94-ea06-471b-a3bd-b671e645f024"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("7be0ce02-908f-4f4c-8159-a2da8fce5b02"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("7c70731e-0f0f-4a10-b0f8-9e8a4c0edf47"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("7e2eec65-4aad-4198-be33-892a72c98075"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("7fbc0773-4813-4735-b7f1-f0a6c2ac8293"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("81fbe7a7-845b-43df-97d9-c5559957cf2a"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("82930e20-a5ad-4c68-9f35-4f0b2227321b"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("835afd22-4f45-4161-a25c-0dfdaa7156f2"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("8536eb07-464e-48ea-bc65-4eb56e3c55fa"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("85626f04-c1b9-4aa2-81ed-dd23c0c7c825"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("86544987-57c6-4404-9951-16311db9ae04"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("8673a9f7-6704-4543-a923-f396f8dd344b"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("86bece61-eb33-4072-9faf-60dfe2770d25"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("8787df98-b91d-448b-a59e-2c4696fc8da9"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("8920d30b-11cc-4edd-88e4-eb4747c80894"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("893d9784-15fd-432d-930c-42502e83bc7b"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("8a75a229-74f7-4a2b-a716-d37b453b0653"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("8cedff48-5ea0-4853-bc14-af15c7713ede"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("8d5be9ef-8b2d-4ce2-8b8e-f692fc1493ee"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("8f7fc7bc-d527-4485-ac72-99b111864b5d"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("8f851ba0-152f-4dee-b915-075492a3d924"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("8f85df02-2af7-498d-9d3a-756437227882"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("908efa41-b467-4afa-843a-c8737eb6b255"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("90fbe6b9-62f0-4090-8836-f444e3c69f3a"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("91e470dc-ea81-41c7-bbae-cd56c56b7f60"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("91e58df0-94c5-4c20-add5-bf154755ec02"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("91fef006-1691-4e9e-99eb-a00595c15494"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("92a55d89-fc71-48b8-8726-6bdda193a5fe"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("93a35a88-aba6-436e-a989-f5c732b78740"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("95564ce0-9119-40b9-9108-9b026e58041b"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("96650047-25f9-4a04-b2c3-8cfc85b535fe"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("96fc32b2-eebe-449a-87b2-26608303ebc8"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("9749038e-2da4-4f72-aa68-f22ca8fc5b22"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("9a251a4c-1144-4f0e-9190-cbe42d8722e2"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("9ba71bb9-2359-4161-8b90-9254b6d657e5"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("9c283d74-b277-4617-9529-0c14658fa861"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("9e07a072-0c73-4f1c-af44-8971621e6895"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("a01f708a-4cbb-45b7-8244-3a075f9141f1"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("a09aeace-71d6-4626-ab00-8b5d7e0fbb3e"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("a0ca1f3b-b015-4062-9e01-f479b454c22d"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("a3126073-5e06-4aa1-bb98-bbcd5faea4c6"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("a475a846-708d-4bfe-a698-6cea840c3c5f"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("a646098b-0a51-4e28-9f33-b88e39fc570f"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("a6d42e06-24db-404e-a76f-19a170811aa3"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("a79410cc-667c-4072-9d83-ddccd5d3aa71"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("a9b91d9d-3c68-4489-97ec-40c4fc02aa41"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("ab4e1cf5-a38f-441e-8c7a-f53f43d085f6"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("ab9ec14a-b947-4ee8-a80e-70bb8e6a91ac"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("abb27f53-cd71-463a-acad-fb39f9736890"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("acb2e158-4fcc-4ea8-8d3f-5003fcbde8dd"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("acd15028-a924-4f51-a19b-0d3e8e0f41aa"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("ad3d85f4-f695-4659-b81a-0062afcf8ea7"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("af09591d-7c49-4cdc-a5f8-da771d99a50e"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("b0db8f95-c31d-40ab-a565-1d3075950ecb"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("b0f0383d-5886-4fe1-8272-469cbcad533a"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("b2bde33b-5341-440c-a330-aa3e6f7fce2c"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("b40eeb81-60db-45a2-94b5-96b734b2baa1"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("b4c962e8-2ca7-4960-976e-a8b77319aa83"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("b51c7f56-d0b4-4575-a013-67c0141c04fd"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("b6728b93-3c7b-48d4-be80-a01f5ce6541e"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("b6c82544-0474-4212-bfd8-d9ed86f5042c"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("b7b01807-4ea0-48ea-82d9-cc581bd4f0ce"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("b83ae6cb-3541-4f41-9226-3e04e2d36f20"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("b9577906-73a7-4b30-9128-76debe79ab12"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("b9d9f4da-a933-463c-bf89-dcf4a8894a66"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("baac0eff-f3f4-4ac1-a0a4-d874d8d81864"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("bb629fbd-48e5-4894-895f-d174ceaaee62"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("bc16c5ce-4850-4c56-a645-5e95414c643e"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("bd0e0527-779f-47c8-a118-c17316613bef"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("bd423845-68e7-47a6-a1b1-2687ac6861dc"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("be6d8d61-11a6-49df-809e-b2d73c1000fb"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("be83875a-d7b6-46e8-90fc-e69954bcc040"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("c45ec80a-5e5b-4572-901e-f32f566ac7e4"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("c5ecd53a-1ef2-4d0e-8ee2-351597d37543"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("c6d38aea-d519-4edf-99fc-7d9e17b9cba1"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("c7fd906e-df26-4dbe-941a-4b2769df4dbf"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("c8426214-c03d-4f87-83d0-f5f17447c011"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("c9c8a461-8064-4424-8f7f-df922367874c"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("cabd1394-4165-4a8d-9017-9af75d763048"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("cb8d573c-c53c-4369-a5ed-e7587a7f0694"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("cc19fffd-c0db-44bf-adf6-5937050f7e33"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("cef14cfd-a81e-47ec-ab60-e3563ebd0117"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("d20176f9-e91e-4f78-b3b4-b739536cc2af"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("d28f355b-50e4-405d-9c66-641f9f24c2e7"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("d326ebaa-9adf-4303-a797-7f892403d9a7"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("d3a90eb5-abf1-4cb1-8b39-840e6a2b49fc"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("d59a7ed7-db6c-48dd-a766-01f705095b50"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("d73f8753-edd5-4c27-9a8f-6ae543469241"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("d896066a-e946-4506-98ab-1def1827589f"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("d8c9e764-d410-46e4-92cd-3492ffb387e2"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("d900ee10-4e1b-4a3f-bd2f-82a6f0b4961f"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("d94abdb6-a1c5-40c6-bd96-94c834e0bfbf"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("da2fbd0d-469f-4680-9ffd-1b7d88f4cecf"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("dc02f635-c996-4f60-8750-8f24d0a8c0bf"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("dc85517b-fefe-465a-a810-931e671f99c2"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("dd86d798-5771-4625-bf6a-f94f27724af7"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("ded68eeb-bc4e-4038-9eb3-a79f3f460bd7"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e1e79f77-7450-4b56-83af-c7fec1f7bfed"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e2032c25-0e33-44bf-bd4d-35a38319245a"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e2f68541-21a6-44a1-b487-0c95a770eaa5"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e32da08f-f041-4126-8dc6-89117736993e"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e368715c-b8d1-4e5c-acd0-8ea85bef937b"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e4170eb8-70cc-4cd2-9d58-15a8583503f5"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e4244925-a9e5-4e9e-8e69-cd4c96f4c8b9"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e5013e63-6a5a-4f02-bedf-d601d1a8e37b"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e653c2d5-2c16-4801-b1d6-aa238bcfe5e9"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e6e6e2c2-2680-45bb-935d-a6aa1ee70fb7"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e73311fc-77b5-404a-ad65-5d2e06fd148c"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e760102e-f243-4a12-ae29-f4885a62a2d3"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e7cd69b5-951e-4f46-b331-716d0fe4c8b7"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e82fa3ed-5f7d-4c26-b791-304e25bec7db"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e86935cf-1fc1-45a7-bc37-3ae2e8fc603c"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e8be0b52-75f3-4c3c-9e2d-91dae42f47a4"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("e930bd88-2eba-4868-bfaf-d05a21a1d863"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("ebd9d480-4d24-4e78-8376-7e0553359d85"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("ec14be3d-7d58-4281-99b9-0422f27508f6"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("ee0844ae-fb7b-42de-8ebf-b01794fd1303"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("ee0f5643-9130-413f-8652-5ecb5facf478"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("ee92c914-ae30-4f32-9fca-813e41041cc0"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("f2535df1-e483-43fc-816a-57bb08ce134c"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("f3d2472e-188e-4a69-896a-da6d2ae66092"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("f44caed0-437d-4e5f-af3d-978a4ea7c2d0"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("f4e938ed-476d-4f4d-90f5-8a229626d74b"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("f5ae52ad-7fdf-43bd-b23d-edd448b024d5"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("f634688f-673a-442d-9a4a-280f1df8ecdb"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("f6bc6e28-0fba-40b8-84f0-951bbd780b50"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("f6cdb998-4c29-41db-8ffd-0b2af9fbb9af"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("f70c10d5-e681-4611-9993-56ac2c8f8eb6"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("f97a79a3-db1d-4ac3-bc08-1d42fd955475"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("f98a67e8-5d06-463d-acef-633d4e26a8df"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("fcab5501-f57d-438b-aa00-d27ee5e2a9b8"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("fe7636a4-9660-4a60-8407-ce598e361c0a"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("ff1844a3-c2f5-411d-bf15-88c7cf0c14bb"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("ff6d164f-abfd-4946-99af-6a5bb3e052ba"));

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "PhoneNumberId",
                keyValue: new Guid("fff17839-2ad3-4b14-a903-d2f3d853af14"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("011bfa78-8079-4b59-9a2b-bc6f6e829c86"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01b6209b-4724-4a1b-8ab1-22694a2927ac"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("025318b8-b68a-4350-ad23-a79900a71bf6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("03206cd0-0a83-4f1d-a4c3-c69cd723a833"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("04783a93-a073-49ba-b314-9a9d07505a23"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0940a8d8-dd0f-40bb-9d3a-06d4d77f7f76"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("11d33233-4672-4563-b05c-75adc34114d0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("132b64b1-abc8-4e60-8d12-f59a86e35478"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("14c01c35-5f30-4b72-b3ac-b488bcb95dd8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1c7e7af7-236c-494b-99ee-f0360a4073ec"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1cfa453c-cf83-4679-8a13-c75e6a9abb9f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ef52785-bff5-417e-bc0c-7f864cb6750b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("235130a9-9b51-4768-b9dc-39c124ecf778"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("242f2320-4c8d-4696-b780-f7fb663444d7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("24d43757-4120-44f4-94c2-ead9d5daddaa"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("26733e03-7af8-4d51-b374-543ab6de1ac2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a14adef-3815-436b-8d13-7ce6f1a47256"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2b788029-2dc1-45b0-ae16-c6b7f8ae99cd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30663ad5-6ea6-4216-9d1f-50ad24153778"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30c2c88e-4d12-44b6-bf65-d7287b23f73a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3164cccf-16f3-43e3-9d84-bdf265d0f042"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3290441b-f700-4c29-8d43-fcfab150d3dc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("32c3b50b-8cf7-4455-a8b1-8baea2a8672f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38ded439-45ec-480b-b66c-cd5cf711bc20"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3a2f1601-ee3c-4dc7-94ae-150487ca9b0e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aad95ba-ed21-43ef-a29c-1f985c073977"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b19b2ed-4bbc-4aeb-893c-751284547402"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b227dd7-3231-42ef-9ca2-d488baa4ac37"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fe9f50d-4c41-4652-a0f0-937333539e23"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("44de57c4-9c49-4a35-a564-3fc0727409b3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4a156734-80e5-46c1-9184-e3de8106c414"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4ae25a95-33f2-4b2d-81b6-219f34d42615"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4dde2dad-30f2-4b98-b6d2-313d1c90448a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("535d42b3-27a3-4778-83ea-bca31d19bc37"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("53c328c6-20a9-4a3b-9139-0dc53eca45b9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5447c5fe-3fa0-48b5-a17e-8250194941f0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("54d641f7-2a06-4e4c-8299-945228d3d445"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5792acc4-4f9f-4be4-9d2b-c8e60d69bc3d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("582c8883-3412-4ed7-98bb-b57fb389c528"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("58ac969d-fb5b-4674-8248-739bad1f3cc1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b8e8690-e89f-465e-b1f1-d1691e63b5a7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5bedb553-aba5-4679-a39b-dd44adebf760"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5bf3624b-e146-4dec-86a1-3c773763a4c6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5cd7308b-03f8-4bf0-aa2f-bdb8009780b5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5d5a349f-fc23-48b4-bb0d-17e4058591db"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5f2e044c-9c21-4457-bba7-8a8b2a3b8506"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("61c06f70-126e-4167-8ea8-6f5345c1b219"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("61f8f359-61ee-4cd6-a874-ed293b646ec2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("620ac83c-2279-47b0-b848-78fdc8ca40bb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("634d60aa-b959-4df2-80df-43de707c5d40"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("64927f99-7a49-4d79-bbb5-792b8fcce77d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("64c389e8-23ea-4152-b164-f47c8b7e14a4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6506db45-d831-4985-a5fc-11c710625d57"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("669427c0-9731-4dd0-bf4e-5ffae835d749"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("66d925b4-240d-410f-8c2b-3699f28468c0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("68190cb1-10ca-4b5c-9498-fa81b7074af7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("685bfb40-42a0-4e36-a25b-18f0594169cd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6865f9d8-82f5-4c58-b134-366bbf5f73cd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("693b0291-d9ec-4538-a406-714a496a19ae"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6ab284a3-d8eb-4902-84a1-daa40cda75ff"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6c41f334-a497-4ad3-b339-4f257df5e8a1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6ca12e95-3c92-4a88-b074-670e3a03e2ad"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d3494e0-2538-4c40-a783-8ac4d7431186"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e5d52e0-6bc4-44c9-ad8d-3e771e7d1a31"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("71406865-5477-4669-8982-3ba5171b622e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72dfada1-6c25-439b-947e-47044854ef32"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7330d9a6-3b24-40c8-8897-1da54d2b22d3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("743a6ccb-c6b7-44b4-b2bc-815d0e1dbc57"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("763309b3-5c69-4dd3-a486-d60fc8fb447f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7b51840b-3208-4d82-b7c3-d70a9d317d52"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7f5da1b7-55fc-4da8-b92e-3e22ac562fdf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8105c062-8cbb-4fd2-8bee-4f8676ba4c77"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("81a84b38-10ae-4bdb-bc69-62d09049f2eb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("83308a21-c0f0-4844-9a80-8f23d092f44d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("87ce0bee-feea-47c9-9746-0f0b2c6811a5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a351105-7a97-477b-b515-54d1920cf06c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8c4ec96b-048a-4caa-ad26-d2287c2cb425"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8c9ecb5d-f75a-48f5-8f8a-aa87a39bf366"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8e589014-f1a8-4126-8752-f93955dda864"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8e607f33-de9b-4ad8-840d-757d73ea219a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8e826ea1-a328-453a-8c98-5ad120afa1b1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("92de0b42-90fc-4112-958f-bed105500378"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("94502636-bcc2-45b7-9c54-586c2d4ba805"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9489d168-a4cb-4b13-bc18-9c899024ebf2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("94b1a2c9-02cb-40a3-a83c-fcbf54eeafcf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9733e81c-8e97-40c8-9dee-04c78313f7ba"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("98f53e72-acee-45c0-ac25-6690ccdd4263"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("99597d95-3f59-40ef-a34e-d61ab094ab7e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9c165e41-013e-4021-8f91-3b83782c785b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9eaac854-9360-4cfb-bba3-17af51a976dc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f538d4b-1209-4cd8-b4f2-2f51bfea213a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9fc79f69-d005-4692-b788-f9cfafc64432"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a22427e4-1bbe-46d6-8a35-e8b186eec051"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a47332d0-0ead-49e5-8a17-c36abbe993cf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a9f1eefe-7275-47ff-9e37-7ed1d62a4fc4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab8e69e0-6bdd-4c58-aa72-b5d7b942a45c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aeb0382e-d0de-4c7b-81a2-0b0bfcb69e7c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b001df7b-2cce-40f9-9c01-9b58f4ce2481"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b195e0be-df91-40ed-a05b-d94ce9e97840"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b3d5fc1e-b00e-4dc5-ba6d-73cbe178995d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b55f356e-5abf-4de3-90bb-651e00a33527"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b731948f-baad-4203-a8a9-132fa96ff98a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b78021d8-89d5-4707-8786-7fbca6c0a574"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8a6b47e-6709-4c50-bef9-3ca557cdec75"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba84b45a-68b2-4f31-89e7-140a158d7c47"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bb37c6ac-6d15-402b-821c-b3cbae534856"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bd25d5bd-6b10-46a7-a317-8be87004d57c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("becdf273-f038-4c47-ac9b-7ddd9f2e1e33"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf1b0969-750b-4537-8f01-ac33cbe04263"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c40f7e4a-2697-484f-9169-40a60f67f790"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c4f5a5c9-bd9e-462d-b070-f3aaa07e0b8a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c4fa5a9f-d66e-44a1-97d0-5345b88a261c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c5058df5-0197-4f7a-93ba-70ba53810ad9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c8cd3068-cee0-4628-ad09-d40c8846af0e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb7a8a7a-1a2f-4172-9641-73213dda6f27"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cc34926c-ae68-4705-be47-32dccb133e04"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1479c7e-0b52-4900-a973-4c23cad398e8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d18a9f4f-c9ff-487d-99c0-418797217186"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d30c69b6-c3bb-4fb8-8db0-6868b777dc84"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d46744dd-f7a6-44dc-9fba-85cb79426654"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d6cc8dd0-5158-4cdb-8023-0881d4e40a7f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d79bd932-238f-4d32-9f20-7df17e05ebb9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d8398457-7807-4084-a625-1dcc46c8c95f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("da7a4c19-d193-47c9-af19-28e8cf7e1cc3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("db1c512a-6034-432f-bd76-96aa6ee64f05"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("de054994-8af5-427d-a0c9-9417c35b53e3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dfa3d718-1b18-434d-ada4-1b7333c74185"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0b44f52-2c1b-4700-8955-8990365341f3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0fddf16-2ee8-4b1b-96fa-728043fc5fdb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e1789da4-c16d-474e-b5b7-e4ea2d7773e1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e1a64f4a-2d75-4d73-b7f3-c0bad04553b3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e4e5fb29-f257-4b37-aeb4-67e99ac407e2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e89e4619-a828-4fc0-91c8-e3a676f37fd8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea96a3ad-97ab-45a2-b388-ad8ae0678a64"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ed291a76-d17f-4119-9ae0-e51f2c416846"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3705edc-b115-4663-a125-b50e5e1a8d61"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4833470-a758-4183-99bb-d6b2de8d76f3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f6c3a216-f660-4b3b-be8f-cffcc9647773"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb0896f7-6e43-466f-903f-b19063ef9b4e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fc459777-d074-47f2-882b-cfb644e51153"));
        }
    }
}
