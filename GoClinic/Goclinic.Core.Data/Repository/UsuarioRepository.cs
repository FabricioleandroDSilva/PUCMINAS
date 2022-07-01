using Goclinic.Agendamento.Core.Business;
using Goclinic.Agendamento.Core.Business.Interfaces;
using Goclinic.Agendamento.Core.Business.Models;
using Goclinic.Agendamento.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Goclinic.Agendamento.Core.Data.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(Contexto context) : base(context) { }

        public  Usuario Autenticar(Usuario users)
        {
            var user = (Db as Contexto).Usuario.FirstOrDefaultAsync(usuario => usuario.Login == users.Login && usuario.Senha == users.Senha).Result;
            if (user == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Configuracao.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Login),
                    new Claim(ClaimTypes.Role, user.TipoAcesso.ToString())

                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var Token = tokenHandler.WriteToken(token);

            return user;

        }

    }
}
