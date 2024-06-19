using EtecVeiculos.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EtecVeiculos.Api.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder modelBuilder)
    {
        #region TipoVeiculo
        List<TipoVeiculo> tipoVeiculos = [
            new() {
               Id = 1,
               Name = "Moto" 
            },
            new() {
               Id = 2,
               Name = "Carro" 
            },
            new() {
               Id = 3,
               Name = "Caminhão" 
            }
         ];

         modelBuilder.Entity<TipoVeiculo>().HasData(tipoVeiculos);
        #endregion 

        #region Marca
            List<Marca> marcas = new() {
                new()
                {
                    Id = 1,
                    Nome = "Chevrolet"
                },
                new()
                {
                    Id = 2,
                    Nome = "Ford"
                },
                new()
                {
                    Id = 3,
                    Nome = "Volkswagen"
                }
            };

            modelBuilder.Entity<Marca>().HasData(marcas);
            #endregion

            #region Modelo
            List<Modelo> modelos = new() {
                new()
                {
                    Id = 1,
                    Nome = "Onix",
                    MarcaId = 1
                },
                new()
                {
                    Id = 2,
                    Nome = " Ecosport",
                    MarcaId = 2
                },
                new()
                {
                    Id = 3,
                    Nome = "Nivus",
                    MarcaId = 2
                }
            };

            modelBuilder.Entity<Modelo>().HasData(modelos);
            #endregion

        }        
    }

