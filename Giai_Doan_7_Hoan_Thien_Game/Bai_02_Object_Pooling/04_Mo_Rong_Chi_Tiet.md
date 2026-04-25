# Mo rong chi tiet: Object Pooling

## 1. Van de ma pooling giai quyet

- Trong nhieu game, mot so object xuat hien roi bien mat lien tuc.
- Vi du dan, hieu ung no, mau be ra, quai sinh ra theo dot.
- Neu moi lan deu `Instantiate` roi `Destroy`, game co the bi ton chi phi cap phat va thu hoi bo nho.
- Dieu nay de gay khung hinh giat cuc, nhat la tren thiet bi yeu.

## 2. Y tuong co ban cua pooling

- Tao san mot nhom object.
- Khi can dung, lay mot object trong nhom ra va bat no len.
- Khi dung xong, tat no di va tra lai pool.
- Nghia la tai su dung thay vi sinh huy lien tuc.

## 3. Cach nghi de nho

- Khach san khong xay phong moi cho tung khach roi dap di sau khi khach roi.
- Ho co san nhieu phong va tai su dung.
- Pooling trong game cung co logic tuong tu.

## 4. Nhung thuong hop rat hop de dung pool

- Vien dan.
- Particle effect ngan.
- Enemy nho xuat hien lap lai.
- Popup sat thuong bay len.
- Pickup duoc tai sinh nhieu lan.

## 5. Khi nao khong nhat thiet dung pool

- Object chi tao mot lan va song suot scene.
- Object qua hiem khi xuat hien.
- Du an rat nho chua can toi uu muc do do.
- Pooling khong phai thuoc than cho moi van de.

## 6. Thanh phan co ban cua mot pool

- Prefab goc.
- So luong khoi tao ban dau.
- Cau truc luu cac object san sang.
- Ham lay object.
- Ham tra object.
- Logic mo rong pool khi het object neu can.

## 7. Queue rat hop cho pool

- `Queue<T>` phu hop khi object duoc lay ra va tra ve theo luong xoay vong.
- No de doc va de hieu cho nguoi moi.
- Tuy nhien khong phai pool nao cung bat buoc dung queue.
- Quan trong la ro luong su dung.

## 8. Pool object khong chi la tat bat

- Khi tra object ve pool, thuong can reset trang thai.
- Vi du dat lai vi tri, van toc, mau sac, timer, animation.
- Neu khong, object moi tai su dung co the mang du lieu cu.
- Day la nguon bug rat pho bien.

## 9. Vi du vien dan

- Player bam ban.
- He thong vu khi yeu cau pool cap mot vien dan.
- Dan duoc dat vi tri nong sung va huong ban.
- Dan bay mot khoang thoi gian.
- Khi trung muc tieu hoac het thoi gian, dan tu tat va tra ve pool.

## 10. Pool va prefab

- Prefab la mau de tao san cac object trong pool.
- Moi phan tu cua pool thuong la instance cua cung mot prefab.
- Day la cach giu hanh vi dong nhat va de quan ly.

## 11. Pool manager va object tu tra ve

- Co the cho pool manager quan ly viec thu hoi.
- Hoac cho moi object biet cach tu tra ve pool sau khi xong viec.
- Vi du `PooledBullet` tu goi pool khi het thoi gian song.
- Chon cach nao tuy du an, nhung voi beginner nen uu tien cach de doc.

## 12. Vi du code pool don gian

```csharp
using System.Collections.Generic;
using UnityEngine;

public class SimplePool : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int initialSize = 10;

    private readonly Queue<GameObject> availableObjects = new Queue<GameObject>();

    private void Awake()
    {
        for (int i = 0; i < initialSize; i++)
        {
            GameObject instance = Instantiate(prefab, transform);
            instance.SetActive(false);
            availableObjects.Enqueue(instance);
        }
    }

    public GameObject Get()
    {
        if (availableObjects.Count == 0)
        {
            GameObject extra = Instantiate(prefab, transform);
            extra.SetActive(false);
            availableObjects.Enqueue(extra);
        }

        GameObject instance = availableObjects.Dequeue();
        instance.SetActive(true);
        return instance;
    }

    public void Return(GameObject instance)
    {
        instance.SetActive(false);
        availableObjects.Enqueue(instance);
    }
}
```

## 13. Vi du object pooled tu dong tra ve

```csharp
using UnityEngine;

public class ReturnToPoolAfterTime : MonoBehaviour
{
    [SerializeField] private float lifetime = 2f;

    private float timer;
    private SimplePool pool;

    public void Initialize(SimplePool ownerPool)
    {
        pool = ownerPool;
    }

    private void OnEnable()
    {
        timer = lifetime;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            pool.Return(gameObject);
        }
    }
}
```

## 14. OnEnable rat huu ich voi pool

- Vi object khong bi tao moi moi lan, `Start` chi chay mot lan.
- Moi lan object duoc bat lai, `OnEnable` co the reset gia tri cho lan su dung moi.
- Day la diem can nho khi dung pooling trong Unity.

## 15. Pool va physics

- Dan co rigidbody khi tra ve pool can reset van toc.
- Neu khong, lan sau duoc lay ra no co the bay voi van toc cu.
- Day la vi du kinh dien cho bug pooling.

## 16. Pool va animation

- Object co animator can reset state khi duoc tai su dung.
- Vi du effect no phai chay lai tu dau.
- Vi du enemy tai sinh phai tro lai animation idle.
- Neu bo qua, object co the xuat hien o giua mot animation cu.

## 17. Pool va UI

- Popup damage number co the duoc pool.
- Thong bao achievement cung co the duoc pool neu xuat hien nhieu.
- Day la cach tot de giam instantiate UI lien tuc.

## 18. Pool va save system

- Pool thuong khong can duoc luu truc tiep trong save file.
- Dieu can luu la du lieu gameplay co y nghia.
- Pool chi la co che toi uu runtime.
- Hieu diem nay se tranh luu nham qua nhieu thong tin vo ich.

## 19. Pool va observer pattern

- Khi enemy chet, he thong co the phat event.
- Listener co the xin effect no tu pool va hien tai vi tri do.
- Day la cach ket hop observer voi pooling rat tu nhien.

## 20. Pool va enemy spawner

- Spawner co the lay enemy tu pool theo tung dot.
- Khi enemy chet, no tra ve pool thay vi bi huy.
- Cach nay phu hop game survival va wave defense.

## 21. Mo rong pool hay co dinh kich thuoc

- Co pool co kich thuoc co dinh de kiem soat tai nguyen.
- Co pool cho phep tu mo rong khi het object.
- Cach nao cung co doi choi rieng.
- Voi nguoi moi, co the cho mo rong de de dung, sau do them gioi han neu can.

## 22. Van de reference khi tra object

- Object pooled thuong can biet no thuoc pool nao.
- Co the gan reference owner pool khi khoi tao.
- Co the co interface reset khi duoc lay ra hoac tra ve.
- Muc tieu la tranh object tro thanh "lang thang" khong biet duong quay lai.

## 23. Loi thuong gap cua nguoi moi

- Tao pool nhung van `Instantiate` trong gameplay moi frame.
- Quen reset trang thai object.
- Quen tra object ve pool.
- Dung `Destroy` tren object dang pooled.
- Nghi `Start` se reset lai moi lan object bat len.

## 24. Checklist khi pool loi

- Object co dang duoc tra ve pool khong?
- `OnEnable` co reset gia tri can thiet khong?
- Rigidbody co duoc dat lai van toc khong?
- Animator co reset state khong?
- Co object nao bi `Destroy` nham khong?
- Pool co het object va khong mo rong khong?

## 25. Bai tap tu hoc

- Tao pool cho vien dan.
- Ban 20 vien lien tuc va quan sat Console, hierarchy.
- Them effect no dung pool.
- Them reset van toc cho dan khi tra ve.
- Thu bat tat object pooled de quan sat `OnEnable`.

## 26. Cau hoi tu kiem tra

- Pooling giai quyet van de gi?
- Vi sao object pooled can reset state?
- Vi sao `OnEnable` quan trong hon `Start` trong nhieu truong hop pooling?
- Vi sao dan va effect la ung vien tot cho pooling?
- Khi nao khong can pooling?

## 27. Ket noi voi bai save va observer

- Pool la co che toi uu runtime.
- Save la co che giu du lieu co y nghia.
- Observer la co che thong bao khi du lieu doi.
- Ba bai nay ket hop voi nhau giup game vua muot, vua ro luong su kien, vua co the tiep tuc choi ve sau.
