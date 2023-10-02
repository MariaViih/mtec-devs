using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MtecDevs.Models;

namespace MtecDevs.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Popular dos dados de TipoDev
        List<TipoDev> tipoDevs = new() {
            new TipoDev() {
                id =1,
                Nome = "fullStack"
            },
            new TipoDev() {
                id =2,
                Nome = "FrondEnd"
            },
            new TipoDev() {
                id =3,
                Nome = "BackEnd"
            },
            new TipoDev() {
                id =4,
                Nome = "Design"
            },
                new TipoDev() {
                id =5,
                Nome = "Jogos"
            }
        };
        builder.Entity<TipoDev>().HasData(tipoDevs);
        #endregion



        #region  Popular dos dados Perfis de Úsuario
        List<IdentityRole> roles = new() {
            new IdentityRole(){
                Id = Guid.NewGuid().ToString(),
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole(){
                Id = Guid.NewGuid().ToString(),
                Name = "Moderador",
                NormalizedName = "MODERADOR"
            },
            new IdentityRole(){
                Id = Guid.NewGuid().ToString(),
                Name = "Usuário",
                NormalizedName = "USUÁRIO"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region  Popular dos dados Úsuarios    
        List<IdentityUser> users = new() {
            new IdentityUser() {
                Id =Guid.NewGuid().ToString(),
                Email = "mariaviih772@gmail.com",
                NormalizedEmail = "MARIAVIIH772@GMAIL.COM",
                UserName = "MariaVitoria",
                NormalizedUserName = "MARIAVITORIA",
                LockoutEnabled = false,
                PhoneNumber = "14997827680",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true
            }
        };

        //criptografar senhas
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "@Etec123");
        }

        //adiciona a conta no banco 
        builder.Entity<IdentityUser>().HasData(users);

        // cria a conta pessoal do Úsuario
        List<Usuario> usuarios = new() {
            new Usuario() {
                UserId = users[0].Id,
                Nome = "MARIAVITORIA",
                DataNascimento = DateTime.Parse("09/06/2006"),
                TipoDevId = 1,
                Foto = "/img/usuarios/avatar.jpg"
            }
        };
        builder.Entity<Usuario>().HasData(usuarios);

        //Associar o úsuario ao tipo de perfil
        List<IdentityUserRole<string>> userRoles = new() {
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);


        #endregion
    }
}