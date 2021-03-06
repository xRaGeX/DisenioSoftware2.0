
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApi_Othello
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //LOGIN ROUTE
            routes.MapRoute(
                "logIn",//ID de la ruta 
                "logIn",//URL, ruta de acceso, para acceder al endPoint
                new
                {
                    controller = "Login",//controlador usado)
                    action = "Login"//metodo a realizar(Login()), está en el controller Login
                }
            );

            routes.MapRoute(
                "ConnectedPlayers",//ID de la ruta 
                "ConnectedPlayers",//URL, ruta de acceso, para acceder al endPoint
                new
                {
                    controller = "Login",//controlador usado)
                    action = "ConnectedPlayers"//metodo a realizar(Login()), está en el controller Login
                }
            );

            routes.MapRoute(
                "logOut",//ID de la ruta 
                "logOut",//URL, ruta de acceso, para acceder al endPoint
                new
                {
                    controller = "Login",//controlador usado)
                    action = "Login"//metodo a realizar(Login()), está en el controller Login
                }
            );

            //EXTRACT STADISTICS
            routes.MapRoute(
                "stadistics",//ID de la ruta 
                "stadistics",//URL, ruta de acceso, para acceder al endPoint
                new
                {
                    controller = "Stadistic",//controlador usado(PersonaController)
                    action = "Get_Stadistics"//metodo a realizar(Login()), está en el controller Login
                }
            );

            routes.MapRoute(
                "movidasPosibles",//ID de la ruta 
                "movidasPosibles",//URL, ruta de acceso, para acceder al endPoint
                new
                {
                    controller = "Juego",//controlador usado(PersonaController)
                    action = "Get_Movidas_Posibles"//metodo a realizar(Get_Movidas_Posibles()), está en el controller Juego
                }
            );

            routes.MapRoute(
                "realizarJugadaJugador",//ID de la ruta 
                "realizarJugadaJugador",//URL, ruta de acceso, para acceder al endPoint
                new
                {
                    controller = "Juego",//controlador usado(PersonaController)
                    action = "Realizar_Jugada_Jugador"//metodo a realizar(Realizar_Jugada_Jug_Jug()), está en el controller Juego
                }
            );

            routes.MapRoute(
                "realizarJugadaSistema",//ID de la ruta 
                "realizarJugadaSistema",//URL, ruta de acceso, para acceder al endPoint
                new
                {
                    controller = "Juego",//controlador usado(PersonaController)
                    action = "Realizar_Jugada_Sistema"//metodo a realizar(Realizar_Jugada_Sis_Sis()), está en el controller Juego
                }
            );

            routes.MapRoute(
                "actualizarPuntos",//ID de la ruta 
                "actualizarPuntos",//URL, ruta de acceso, para acceder al endPoint
                new
                {
                    controller = "Juego",//controlador usado(PersonaController)
                    action = "actualizar_Puntos_Jugador"//metodo a realizar(Realizar_Jugada_Sis_Sis()), está en el controller Juego
                }
            );

            routes.MapRoute(
                "actualizarSesion",//ID de la ruta 
                "actualizarSesion",//URL, ruta de acceso, para acceder al endPoint
                new
                {
                    controller = "Juego",//controlador usado(PersonaController)
                    action = "actualizarSesion"//metodo a realizar(Realizar_Jugada_Sis_Sis()), está en el controller Juego
                }
            );

            routes.MapRoute(
                "crearSesion",//ID de la ruta 
                "crearSesion",//URL, ruta de acceso, para acceder al endPoint
                new
                {
                    controller = "Juego",//controlador usado(PersonaController)
                    action = "crearSesion"//metodo a realizar(Realizar_Jugada_Sis_Sis()), está en el controller Juego
                }
            );

            routes.MapRoute(
                "borrarSesion",//ID de la ruta 
                "borrarSesion",//URL, ruta de acceso, para acceder al endPoint
                new
                {
                    controller = "Juego",//controlador usado(PersonaController)
                    action = "borrarSesion"//metodo a realizar(Realizar_Jugada_Sis_Sis()), está en el controller Juego
                }
            );

            routes.MapRoute(
                "extraerSesiones",//ID de la ruta 
                "extraerSesiones",//URL, ruta de acceso, para acceder al endPoint
                new
                {
                    controller = "Juego",//controlador usado(PersonaController)
                    action = "extraer_sesiones"//
                }
            );

            routes.MapRoute(
                "extraerSesion",//ID de la ruta 
                "extraerSesion",//URL, ruta de acceso, para acceder al endPoint
                new
                {
                    controller = "Juego",//controlador usado(PersonaController)
                    action = "extraer_sesion"//
                }
            );

            routes.MapRoute(
                "extraerJugadores",//ID de la ruta 
                "extraerJugadores",//URL, ruta de acceso, para acceder al endPoint
                new
                {
                    controller = "Juego",//controlador usado(PersonaController)
                    action = "extraer_jugadores"//
                }
            );

            routes.MapRoute(
                "aceptarSesion",//ID de la ruta 
                "aceptarSesion",//URL, ruta de acceso, para acceder al endPoint
                new
                {
                    controller = "Juego",//controlador usado(JuegoController)
                    action = "aceptarSesion"//
                }
            );

            routes.MapRoute(
                "updateFichaJ2",//ID de la ruta 
                "updateFichaJ2",//URL, ruta de acceso, para acceder al endPoint
                new
                {
                    controller = "Juego",//controlador usado(JuegoController)
                    action = "updateFichaJ2"//
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
