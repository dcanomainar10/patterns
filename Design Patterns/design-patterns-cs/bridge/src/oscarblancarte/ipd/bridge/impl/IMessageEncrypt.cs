/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
namespace oscarblancarte.ipd.bridge.impl{
    public interface IMessageEncrypt {
        string EncryptMessage(string message, string password);
    }
}