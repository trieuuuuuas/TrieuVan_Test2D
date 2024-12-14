using UnityEngine;

public class ShowObjectsSequence : MonoBehaviour
{
    // Các đối tượng cần hiển thị
    public GameObject title;
    public GameObject gem_0;
    public GameObject text_gem;
    public GameObject arrow_one;
    public GameObject hoe;
    public GameObject text_hoe;
    public GameObject arrow_two;
    public GameObject find_gem;
    public GameObject text_find;
    public GameObject arrow_three;
    public GameObject coin;
    public GameObject text_coin;
    public GameObject text_tap;

    // Thời gian delay trước khi xuất hiện các đối tượng
    public float delayTitle = 0f;
    public float delayGem = 2f;
    public float delayArrowOne = 2.5f;
    public float delayHoe = 3f;
    public float delayArrowTwo = 3.5f;
    public float delayFindGem = 4f;
    public float delayArrowThree = 4.5f;
    public float delayCoin = 5f;
    public float delayTapText = 5.5f;

    void Start()
    {
        // Ẩn tất cả các đối tượng ban đầu
        title.SetActive(false);
        gem_0.SetActive(false);
        text_gem.SetActive(false);
        arrow_one.SetActive(false);
        hoe.SetActive(false);
        text_hoe.SetActive(false);
        arrow_two.SetActive(false);
        find_gem.SetActive(false);
        text_find.SetActive(false);
        arrow_three.SetActive(false);
        coin.SetActive(false);
        text_coin.SetActive(false);
        text_tap.SetActive(false);

        // Gọi phương thức để hiển thị title trước
        Invoke("ShowTitle", delayTitle);
    }

    void ShowTitle()
    {
        // Hiển thị title
        title.SetActive(true);

        // Hiển thị gem và text_gem sau delay
        Invoke("ShowGemAndText", delayGem);
    }

    void ShowGemAndText()
    {
        // Hiển thị gem_0 và text_gem
        gem_0.SetActive(true);
        text_gem.SetActive(true);

        // Hiển thị arrow_one sau delay
        Invoke("ShowArrowOne", delayArrowOne);
    }

    void ShowArrowOne()
    {
        // Hiển thị arrow_one
        arrow_one.SetActive(true);

        // Hiển thị hoe và text_hoe sau delay
        Invoke("ShowHoeAndText", delayHoe);
    }

    void ShowHoeAndText()
    {
        // Hiển thị hoe và text_hoe
        hoe.SetActive(true);
        text_hoe.SetActive(true);

        // Hiển thị arrow_two sau delay
        Invoke("ShowArrowTwo", delayArrowTwo);
    }

    void ShowArrowTwo()
    {
        // Hiển thị arrow_two
        arrow_two.SetActive(true);

        // Hiển thị find_gem và text_find sau delay
        Invoke("ShowFindGemAndText", delayFindGem);
    }

    void ShowFindGemAndText()
    {
        // Hiển thị find_gem và text_find
        find_gem.SetActive(true);
        text_find.SetActive(true);

        // Hiển thị arrow_three sau delay
        Invoke("ShowArrowThree", delayArrowThree);
    }

    void ShowArrowThree()
    {
        // Hiển thị arrow_three
        arrow_three.SetActive(true);

        // Hiển thị coin và text_coin sau delay
        Invoke("ShowCoinAndText", delayCoin);
    }

    void ShowCoinAndText()
    {
        // Hiển thị coin và text_coin
        coin.SetActive(true);
        text_coin.SetActive(true);

        // Hiển thị text_tap sau delay
        Invoke("ShowTextTap", delayTapText);
    }

    void ShowTextTap()
    {
        // Hiển thị text_tap
        text_tap.SetActive(true);
    }
}
