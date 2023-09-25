using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MtecDevs.Models;

namespace MtecDevs.Data
{
    public class AppDbSeed  
    
        public AppDbSeed(ModelBuilder builder)
        {
            #region Popular dos dados de TipoDev
            List<TipoDev>tipoDevs = new() {
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
            List<TipoDev> tiposDevs = new() {
                 builder.Entity<TipoDev>().HasData(tiposDevs);
            }
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
                },
            };
            builder.Entity<IdentityRole>().HasData(roles);

            #region  Popular dos dados Úsuarios    
            List<IdentityUser> users = new() {
                new IdentityUser() {
                    Id =Guid.NewGuid().ToString(),
                    Email = "mariaviih772@gmail.com",
                    NormalizedEmail = "MARIAVIIH772@GMAIL.COM",
                    UserName = "Maria Vitória",
                    NormalizedUserName = "MARIAVITÓRIA",
                    

                }
                
            };

            //criptografar senhas
            foreach (var item in users){
              PasswordHash<IdentityUser> pass = new();  
              user.PasswordHash = Pass.HashPassword(User, "@Etec123");
            }

            //adiciona a conta no banco 
            UriBuilder.Entity<IdentityUser>
        }
    
}
