using Firebase.Auth;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vakanuvis
{
    internal class FirebaseService
    {
        private string firebaseUrl = "https://firestore.googleapis.com/v1/projects/f-flutter-vakanuvis/databases/(default)/documents/users";
        private FirebaseAuthProvider authProvider;
        private HttpClient client;

        public FirebaseService(string apiKey)
        {
            authProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
            client = new HttpClient();
        }

        //giriş yap
        public async Task<FirebaseAuthLink> LoginAsync(string email, string password)
        {
            try
            {
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
                return auth;
            }
            catch (FirebaseAuthException ex) {

                 MessageBox.Show($"hata: {ex.Reason}");
                return  null;
            }
        }
    }
}
