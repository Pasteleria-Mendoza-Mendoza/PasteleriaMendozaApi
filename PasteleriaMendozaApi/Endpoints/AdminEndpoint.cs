using Api.DTOs;
using Api.DTOs.Admin.DTOs;
using PasteleriaMendozaApi.Models.DAL;
using PasteleriaMendozaApi.Models.EN;

namespace PasteleriaMendozaApi.Endpoints
{
    public static class AdminEndpoint
    {
        public static void AddAdminEndpoints(this WebApplication app)
        {
            app.MapGet("/admin/{id}",async (int id, AdminsDAL admindDAL)=>
            {
                var admin = await admindDAL.GetById(id);

                var adminResult = new GetidResultAdminDTO
                {
                    Id = admin.Id,
                    Name = admin.Name,
                    Password = admin.Password
                };
                if (adminResult.Id > 0)
                    return Results.Ok(adminResult);
                else
                    return Results.NotFound(adminResult);
            });

            app.MapPost("/admin",async (CreateAdminDTO createAdminDTO,AdminsDAL adminsDAL)=>
            {
                var admin = new AdminEn
                {
                    Name = createAdminDTO.Name,
                    Password = createAdminDTO.Password
                };
                int result = await adminsDAL.Create(admin);
                if (result !=0)
                    return Results.Ok(result);
                else
                    return Results.StatusCode(500);
            });

            app.MapPut("/admin", async (EditAdminDTO editAdminDTO, AdminsDAL adminsDAL)=>
            {
                var admin = new AdminEn
                {
                    Id = editAdminDTO.Id,
                    Name = editAdminDTO.Name,
                    Password = editAdminDTO.Password
                };

                int result = await adminsDAL.Edit(admin);
                if (result != 0)
                    return Results.Ok(result);
                else
                    return Results.StatusCode(500);
            });

            app.MapDelete("/admin/{id}", async (int id,AdminsDAL adminDAL)=>
            {
                int result = await adminDAL.Delete(id);
                if (result != 0 )
                    return Results.Ok(result);
                else
                    return Results.StatusCode(500);
            });
        }
    }
}