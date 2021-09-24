using System;
using Equipo;
using Detalle_Partido;

namespace TorneoDeFutbol.App.Dominio

{
    public class Partido
    {
     public   int Id_Partido { get;set; }
     public   DateTime Fecha { get;set; }
     public   DateTime Hora { get;set; }
     public   int EquipoVisitante_Id { get;set; }
     public   int EquipoLocal_Id { get;set; }
     public   int GolesLocal { get;set; }
     public   int GolesVisitante { get;set; }
     public   int Marcador { get;set; }
     public   int Estadio_Id { get;set; }
     public   int Detalle_Id { get;set; }
     public   Equipo Equipo_Local
     public   Detalle_Partido detalle_partido    

    
  
  
  "/*"
  INDEX `fk_Partido_EquipoLocal1_idx` (`EquipoLocal_Id` ASC) VISIBLE,
  INDEX `fk_Partido_EquipoVisitante1_idx` (`EquipoVisitante_Id` ASC) VISIBLE,
  INDEX `fk_Partido_Estadio1_idx` (`Estadio_Id` ASC) VISIBLE,
  INDEX `fk_Partido_Arbitro1_idx` (`Arbitro_Id` ASC) VISIBLE,
  INDEX `fk_Partido_Detalle1_idx` (`Detalle_Id` ASC) VISIBLE,
  CONSTRAINT `fk_Partido_EquipoLocal1`
    FOREIGN KEY (`EquipoLocal_Id`)
    REFERENCES `mydb`.`EquipoLocal` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Partido_EquipoVisitante1`
    FOREIGN KEY (`EquipoVisitante_Id`)
    REFERENCES `mydb`.`EquipoVisitante` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Partido_Estadio1`
    FOREIGN KEY (`Estadio_Id`)
    REFERENCES `mydb`.`Estadio` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Partido_Arbitro1`
    FOREIGN KEY (`Arbitro_Id`)
    REFERENCES `mydb`.`Arbitro` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Partido_Detalle1`
    FOREIGN KEY (`Detalle_Id`)
    REFERENCES `mydb`.`Detalle` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
     

    "*/"

    }
}