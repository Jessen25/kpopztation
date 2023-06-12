using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Handler;
using KpopZtation.Model;
using KpopZtation.Repository;

namespace KpopZtation.Controller
{
    public class CartController
    {
        public static String createCart(int CustomerID, int AlbumID, int Quantity)
        {
            Cart SelectedCart = CartRepository.findCartbyAlbumID(CustomerID.ToString(), AlbumID.ToString());
            Album SelectedAlbum = AlbumRepository.getAlbumById(AlbumID.ToString());


            if (SelectedCart == null)
            {
                if (SelectedAlbum.AlbumStock < Quantity)
                {
                    return "The quantity cannot exceed the stock !";
                }

                CartHandler.createCart(CustomerID, AlbumID, Quantity);
            }
            else
            {
                if (SelectedAlbum.AlbumStock < SelectedCart.Qty + Quantity)
                {
                    return "The quantity cannot exceed the stock !";
                }

                CartHandler.updateCart(SelectedCart, Quantity);
            }

            return "Inserted Successfuly !";
        }
        public static List<Cart> getCart(int id)
        {
            return CartHandler.getCart(id);
        }

        public static void deleteCartItem(String CustomerId, String AlbumId)
        {
            CartHandler.deleteCartitem(CustomerId, AlbumId);
        }

        public static void deleteCart(String CustomerId)
        {
            CartHandler.deleteCart(CustomerId);
        }

        public static string CartisEmpty(int customerId)
        {
            List<Cart> SelectedCart = CartHandler.getCart(customerId);

            if (SelectedCart.Count == 0)
            {
                return "Cart is Empty !";
            }
            else
            {
                return null;
            }
        }
    }
}