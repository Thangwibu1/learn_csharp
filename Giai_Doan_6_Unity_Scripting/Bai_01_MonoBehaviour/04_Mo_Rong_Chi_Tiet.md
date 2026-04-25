# Mo rong chi tiet: MonoBehaviour

## 1. MonoBehaviour la diem vao cua script Unity

- Khi hoc Unity scripting, `MonoBehaviour` la khai niem can nam dau tien.
- Day la lop co so de script cua ban co the gan vao `GameObject`.
- Khi script ke thua `MonoBehaviour`, Unity co the goi cac ham vong doi song cua no.
- Neu khong ke thua `MonoBehaviour`, class van la class C# hop le, nhung khong hoat dong nhu component trong scene.

## 2. Script trong Unity khac gi class C# thong thuong

- Class C# thong thuong co the duoc tao bang `new`.
- Script `MonoBehaviour` thuong ton tai nhu mot component gan vao object.
- Unity quan ly vong doi song cho no.
- Unity tu dong goi nhieu ham dac biet theo thoi diem phu hop.
- Day la ly do Unity co cam giac vua la C#, vua la mot he thong component rieng.

## 3. Cach nghi don gian

- `GameObject` la vat chu.
- `MonoBehaviour` la bo nao hoac bo phan hanh vi duoc gan len vat chu do.
- Mot object co the co nhieu script `MonoBehaviour` cung ton tai.
- Moi script nen giai quyet mot nhom trach nhiem ro rang.

## 4. Cac ham vong doi song quan trong

- `Awake()`
- `OnEnable()`
- `Start()`
- `Update()`
- `FixedUpdate()`
- `LateUpdate()`
- `OnDisable()`
- `OnDestroy()`

## 5. Awake dung khi nao

- `Awake` chay rat som khi component duoc khoi tao.
- Thuong dung de lay reference component can thiet.
- Vi du lay `Rigidbody2D`, `Animator`, `Health`.
- Khong nen phu thuoc vao object khac da `Start` xong trong giai doan nay neu chua chac thu tu.
- `Awake` hop voi khoi tao noi bo cua chinh object.

## 6. OnEnable dung khi nao

- `OnEnable` duoc goi moi khi component hoac object duoc bat.
- Rat hop de dang ky event.
- Vi du dang ky nghe su kien thay doi mau, su kien pause, su kien song chet.
- Neu component bi tat roi bat lai, `OnEnable` se chay lai.

## 7. Start dung khi nao

- `Start` thuong chay truoc frame dau tien khi component dang bat.
- No rat hop de khoi tao khi can scene da san sang hon.
- Nhieu nguoi moi xem `Start` la noi dat gia tri bat dau.
- Dieu nay dung trong nhieu truong hop, nhung van can hieu `Awake` va `Start` khac nhau.

## 8. Update la gi

- `Update` chay moi frame.
- Day la noi thuong dung cho input, logic theo frame, kiem tra dieu kien lien tuc.
- Vi du doc phim, quay camera, di chuyen khong dua tren vat ly.
- Do chay rat nhieu, `Update` can duoc viet gon va ro.

## 9. FixedUpdate la gi

- `FixedUpdate` chay theo buoc thoi gian vat ly.
- Thuong dung cho logic lien quan `Rigidbody`.
- Vi du them luc, di chuyen bang vat ly, kiem tra vat ly dinh ky.
- Nguoi moi hay dat moi thu vao `Update`, nhung vat ly thuong hop hon trong `FixedUpdate`.

## 10. LateUpdate la gi

- `LateUpdate` chay sau `Update`.
- Thuong dung cho doi tuong can theo sau ket qua da cap nhat xong.
- Vi du camera theo nhan vat sau khi nhan vat da di chuyen trong `Update`.
- Day la cach giam do lech va giat do thu tu cap nhat.

## 11. OnDisable va OnDestroy

- `OnDisable` goi khi component bi tat hoac object bi tat.
- Rat hop de huy dang ky event.
- `OnDestroy` goi khi object bi huy that su.
- Nguoi moi hay quen huy event, de dan den loi nghe trung hoac ro ri tham chieu.

## 12. Thu tu can nho cho nguoi moi

- Khoi tao som: `Awake`
- Bat component: `OnEnable`
- Bat dau san sang: `Start`
- Moi frame: `Update`
- Buoc vat ly: `FixedUpdate`
- Sau cung trong frame: `LateUpdate`
- Tat component: `OnDisable`
- Huy object: `OnDestroy`

## 13. Vi du script don gian

```csharp
using UnityEngine;

public class LifeCycleExample : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void Start()
    {
        Debug.Log("Start");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space pressed");
        }
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
}
```

- Vi du nay giup nhin ro Unity tu goi ham theo thoi diem nao.

## 14. Time.deltaTime la gi

- `Update` phu thuoc vao so frame moi giay.
- Neu may nhanh, `Update` goi nhieu hon.
- Neu may cham, `Update` goi it hon.
- Vi vay chuyen dong thuong nhan voi `Time.deltaTime`.
- Dieu nay giup toc do dua tren thoi gian thay vi dua tren so frame.

## 15. Vi du chuyen dong dung deltaTime

```csharp
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    private void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
```

- Neu bo `Time.deltaTime`, vat se chay nhanh hay cham tuy may.

## 16. Inspector va SerializeField

- Bien `public` co the hien tren Inspector, nhung cung mo truy cap tu ben ngoai.
- `[SerializeField] private` giu dong goi tot hon ma van cho chinh trong Inspector.
- Day la thoi quen dep nen hoc som.
- Vi du toc do, mau toi da, sat thuong khoi dau.

## 17. Caching component

- Nguoi moi hay goi `GetComponent` lap lai trong `Update`.
- Cach nay khong dep va de roi code.
- Thuong ta lay component mot lan trong `Awake` hoac `Start`.
- Sau do luu vao bien rieng de dung lai.

## 18. MonoBehaviour va GameObject/component thinking

- Script khong bay trong chan khong.
- Script gan vao mot object cu the.
- No song cung cac component khac tren object do.
- No co the noi chuyen voi component khac de tao hanh vi tong hop.
- Day la ly do phai luon nghi theo object va component, khong chi theo class.

## 19. Khi nao khong can MonoBehaviour

- Khong phai moi class trong du an deu can ke thua `MonoBehaviour`.
- Class du lieu, class helper, state machine state, save data thuong co the la class C# thuong.
- Chi nhung gi can gan vao object hoac can Unity goi lifecycle moi can `MonoBehaviour`.
- Hoc diem nay se giup kien truc sach hon.

## 20. Coroutines la mot suc manh cua MonoBehaviour

- `MonoBehaviour` cho phep dung `StartCoroutine`.
- Coroutine huu ich cho logic theo thoi gian.
- Vi du cho no hien text trong 2 giay, doi roi tat effect, spawn theo nhịp.
- Day la cach nhe hon so voi viec tu viet he thong timer phuc tap luc moi hoc.

## 21. Vi du coroutine ngan

```csharp
using System.Collections;
using UnityEngine;

public class BlinkExample : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        StartCoroutine(BlinkRoutine());
    }

    private IEnumerator BlinkRoutine()
    {
        while (true)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
            yield return new WaitForSeconds(0.2f);
        }
    }
}
```

## 22. Tranh nhoi qua nhieu vao Update

- `Update` la noi bi lam dung qua muc rat thuong xuyen.
- Khong phai moi logic deu can chay moi frame.
- UI chi can cap nhat khi du lieu doi.
- Save game khong can luu moi frame.
- Achievement khong can polling lien tuc neu co event.
- Day la cau noi den cac bai observer va save system ve sau.

## 23. Input, vat ly, UI nen dat dung cho

- Doc input thuong trong `Update`.
- Tac dong vat ly thuong trong `FixedUpdate`.
- Camera theo doi thuong trong `LateUpdate`.
- Event dang ky trong `OnEnable`.
- Event huy dang ky trong `OnDisable`.
- Nho quy tac nay se giam rat nhieu loi logic.

## 24. Thu tu script co the gay nham lan

- Nhieu script tren nhieu object co the cung co `Awake` va `Start`.
- Thu tu giua chung co the khong giong dieu ban tu nghi.
- Vi vay khong nen dua vao gia dinh mo ho.
- Neu can phu thuoc ro, hay thiet ke lai luong khoi tao de an toan.

## 25. Null reference la loi pho bien

- Script thuong loi vi bien tham chieu chua duoc gan.
- Vi du quen gan `playerHealth` trong Inspector.
- Vi du `GetComponent` tra ve null vi object khong co component do.
- Luon doc Console khi gap loi nay.
- Doc ten file va dong loi se giup tim nhanh.

## 26. MonoBehaviour va Prefab

- Script gan tren prefab se duoc mang theo moi instance.
- Day rat huu ich de tai su dung hanh vi.
- Vi du prefab `Bullet` co script `BulletMovement`.
- Moi vien dan moi sinh ra deu co hanh vi giong nhau.

## 27. Loi thuong gap cua nguoi moi

- Khong hieu khac biet `Awake` va `Start`.
- Nhét qua nhieu logic vao `Update`.
- Dung vat ly trong `Update` thay vi `FixedUpdate`.
- Quen `Time.deltaTime`.
- Quen huy dang ky event trong `OnDisable`.
- Nghĩ class nao trong Unity cung phai la `MonoBehaviour`.

## 28. Quy tac thuc dung nen nho

- Khoi tao reference trong `Awake`.
- Dang ky event trong `OnEnable`.
- Gan gia tri san sang trong `Start`.
- Doc input trong `Update`.
- Tac dong rigidbody trong `FixedUpdate`.
- Camera theo sau trong `LateUpdate`.
- Huy dang ky event trong `OnDisable`.

## 29. Bai tap tu hoc

- Viet mot script in ra thu tu `Awake`, `OnEnable`, `Start`.
- Tao mot object tu di chuyen sang phai trong `Update` voi `deltaTime`.
- Tao mot object su dung `FixedUpdate` de day rigidbody.
- Tao camera theo nhan vat trong `LateUpdate`.
- Thu tat bat object de quan sat `OnEnable` va `OnDisable`.

## 30. Ket noi voi bai sau

- Sau khi hieu `MonoBehaviour`, ban se de tiep can `Physics`, `Input`, `UI`, `Animation`, `Observer Pattern` va `State Machine`.
- Tat ca cac chu de do deu duoc dat len tren nen tang lifecycle nay.

## 31. MonoBehaviour day ban nghi theo thoi diem

- Cung mot logic dat o hai ham khac nhau co the cho ket qua khac nhau.
- Vi vay hoc lifecycle la hoc cach dat code dung thoi diem.
- Day la ky nang cot loi trong Unity.

## 32. Khi nao can tranh Update

- Khi logic khong can cap nhat moi frame.
- Khi co the chay theo event.
- Khi chi can xu ly moi vai giay.
- Khi UI chi can doi khi du lieu doi.
- Day la cach code nhe hon va ro hon.

## 33. MonoBehaviour khong thay the thiet ke tot

- Ke thua `MonoBehaviour` khong tu dong lam code dep.
- Ban van can tach trach nhiem.
- Van can dat ten ro rang.
- Van can chon lifecycle phu hop.
- Day la cong cu, khong phai phep mau.

## 34. Cang hieu lifecycle, cang debug nhanh

- Script chua khoi tao? Nhin `Awake` va `Start`.
- Event bi nghe trung? Nhin `OnEnable` va `OnDisable`.
- Camera giat? Nhin `LateUpdate`.
- Vat ly la? Nhin `FixedUpdate`.
- Day la mau debug rat co he thong.

## 35. Script component song trong scene chu khong song doc lap

- No phu thuoc object dang active khong.
- No phu thuoc component co enabled khong.
- No phu thuoc cac component khac co san khong.
- Day la ly do debug Unity can nhin ca editor lan code.

## 36. Moi ham lifecycle la mot loi hua cua engine

- Unity noi rang: toi se goi ham nay o thoi diem nay.
- Nhiem vu cua ban la dung no cho dung viec.
- Neu dat sai cho, bug de xuat hien.
- Neu dat dung cho, code se ro va de mo rong hon.

## 37. Coroutines la cau noi giua frame va thoi gian

- Khong phai logic nao cung la moi frame hoac moi buoc vat ly.
- Co logic la doi 0.2 giay, doi 3 giay, doi hieu ung xong.
- Coroutine la cach Unity giup ban viet dieu do rat tu nhien.
- Day la suc manh rat de dung cua MonoBehaviour.

## 38. Event va lifecycle di cung nhau

- Dang ky trong `OnEnable`.
- Huy dang ky trong `OnDisable`.
- Quy tac nay de nho va rat huu dung.
- No giam nhieu bug kho tim khi object bi tat bat lai.

## 39. MonoBehaviour va test scene

- Khi hoc lifecycle, nen co scene nho de test rieng.
- Mot object logger.
- Mot object follower.
- Mot rigidbody.
- Mot nut tat bat object.
- Cach hoc truc quan nay giup hieu nhanh hon doc ly thuyet suong.

## 40. Tong ket bo sung

- `MonoBehaviour` la khuon vao he thong scene.
- Lifecycle la ban do thoi diem.
- Nam chac hai diem nay, ban se viet script Unity co y thuc hon nhieu.
