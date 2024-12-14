using UnityEngine;
using UnityEngine.SceneManagement;  // Cần sử dụng để quản lý các scene
using UnityEngine.EventSystems;   // Cần sử dụng để xử lý sự kiện click

public class MainMenuController : MonoBehaviour
{
    // Phương thức này được gọi khi người dùng click vào Image Start
    public void OnStartImageClicked()
    {
        // Sử dụng SceneManager để chuyển tới scene TutorialScene
        SceneManager.LoadScene("TutorialScene");
    }
}
