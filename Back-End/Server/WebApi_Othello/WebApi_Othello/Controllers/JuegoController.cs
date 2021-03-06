﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi_Othello.Models;

namespace WebApi_Othello.Controllers
{
    public class JuegoController : Controller
    {
        private Juego juego;

        public JuegoController()
        {
            this.juego = new Juego();
        }

        public JsonResult Get_Movidas_Posibles(int size, int level, String jugadorActual, List<String> posFichasJ1, List<String> posFichasJ2)
        {
            switch (Request.HttpMethod)
            {
                case "GET":
                    return Json(juego.retornarMovidasPosibles(size, level, jugadorActual, posFichasJ1, posFichasJ2),
                                JsonRequestBehavior.AllowGet);
                case "POST":
                    return Json(juego.retornarMovidasPosibles(size, level, jugadorActual, posFichasJ1, posFichasJ2));
            }

            return Json(new { Error = true, Message = "Operación HTTP desconocida" });
        }
        
        public JsonResult Realizar_Jugada_Jugador(int size, int level, String jugadorActual, int x, int y, List<String> posFichasJ1, List<String> posFichasJ2)
        {
            switch (Request.HttpMethod)
            {
                case "POST":
                    return Json(juego.jugadaJugador(size, level, jugadorActual, x, y, posFichasJ1, posFichasJ2));
            }

            return Json(new { Error = true, Message = "Operación HTTP desconocida" });
        }

        public JsonResult Realizar_Jugada_Sistema(int size, int level, String jugadorActual, List<String> posFichasJ1, List<String> posFichasJ2)
        {
            switch (Request.HttpMethod)
            {
                case "POST":
                    return Json(juego.jugadaSistema(size, level, jugadorActual, posFichasJ1, posFichasJ2));
            }

            return Json(new { Error = true, Message = "Operación HTTP desconocida" });
        }
        

        public JsonResult actualizar_Puntos_Jugador(Estadisticas_Model stats)
        {
            switch (Request.HttpMethod)
            {
                case "POST":
                    return Json(juego.actualizarPuntosBD(stats));
            }

            return Json(new { Error = true, Message = "Operación HTTP desconocida" });
        }

        public JsonResult crearSesion(string ID_Jugador1, string ID_Jugador2, int tam_matriz,string fichaJ1, int CantPartidas)
        {
            switch (Request.HttpMethod)
            {
                case "POST":
                    return Json(juego.crearSesion(ID_Jugador1, ID_Jugador2,tam_matriz,fichaJ1,CantPartidas));
            }

            return Json(new { Error = true, Message = "Operación HTTP desconocida" });
        }

        public JsonResult updateFichaJ2(int ID_Sesion, string fichaJ2)
        {
            switch (Request.HttpMethod)
            {
                case "POST":
                    return Json(juego.updateFichaJ2(ID_Sesion,fichaJ2));
            }

            return Json(new { Error = true, Message = "Operación HTTP desconocida" });
        }

        public JsonResult borrarSesion(int ID_Sesion)
        {
            switch (Request.HttpMethod)
            {
                case "POST":
                    return Json(juego.borrarSesion(ID_Sesion));
            }

            return Json(new { Error = true, Message = "Operación HTTP desconocida" });
        }

        public JsonResult actualizarSesion(Sesion sesion)
        {
            switch (Request.HttpMethod)
            {
                case "POST":
                    return Json(juego.actualizar_Sesion(sesion));
            }

            return Json(new { Error = true, Message = "Operación HTTP desconocida" });
        }

        public JsonResult extraer_sesiones(string ID_Facebook)
        {
            switch (Request.HttpMethod)
            {
                case "POST":
                    return Json(juego.extraer_sesiones(ID_Facebook));
            }

            return Json(new { Error = true, Message = "Operación HTTP desconocida" });
        }

        public JsonResult extraer_sesion(string ID_J1, string ID_J2)
        {
            switch (Request.HttpMethod)
            {
                case "POST":
                    return Json(juego.extraer_sesion(ID_J1,ID_J2));
            }

            return Json(new { Error = true, Message = "Operación HTTP desconocida" });
        }

        public JsonResult extraer_jugadores()
        {
            switch (Request.HttpMethod)
            {
                case "POST":
                    return Json(juego.extraer_jugadores());
            }

            return Json(new { Error = true, Message = "Operación HTTP desconocida" });
        }

        public JsonResult aceptarSesion(int ID_Sesion)
        {
            switch (Request.HttpMethod)
            {
                case "POST":
                    return Json(juego.aceptar_sesion(ID_Sesion));
            }

            return Json(new { Error = true, Message = "Operación HTTP desconocida" });
        }



    }
}