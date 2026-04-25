# Mo rong chi tiet: GameObject va Component

## 1. Tu duy cot loi cua Unity

- Unity xoay quanh `GameObject` va `Component`.
- Nguoi moi hoc Unity tot hay khong phu thuoc rat nhieu vao viec hieu hai khai niem nay.
- Neu hieu ro, ban se doc scene de hon.
- Neu hieu ro, ban se viet script de tach trach nhiem hon.

## 2. GameObject la chiec hop rong

- Ban co the xem `GameObject` nhu mot chiec hop ten.
- Ban than chiec hop khong lam duoc nhieu viec.
- No can cac `Component` de co hanh vi.
- Khi tao mot GameObject moi, Unity gan san `Transform`.
- Dieu nay cho thay vi tri la nen tang cua moi object.

## 3. Component la manh chuc nang gan len object

- Moi component giai quyet mot nhiem vu cu the.
- `Transform` quan ly vi tri, xoay, kich thuoc.
- `SpriteRenderer` ve hinh 2D.
- `Rigidbody2D` xu ly vat ly 2D.
- `BoxCollider2D` tao vung va cham.
- Script cua ban cung la mot component.
- Day la cach Unity dua logic vao game.

## 4. Composition thay vi ke thua sau

- Unity uu tien `composition` hon `inheritance` sau nhieu tang.
- Nghia la ban ghep tinh nang bang nhieu component nho.
- Cach nay linh hoat hon viec tao mot class khong lo cho moi doi tuong.
- Cung mot script co the duoc tai su dung tren nhieu object.
- Cung mot object co the co nhieu component ket hop.

## 5. Vi du don gian

- `Coin` co `Transform`, `SpriteRenderer`, `CircleCollider2D`, `CoinPickup`.
- `Enemy` co `Transform`, `SpriteRenderer`, `Rigidbody2D`, `Collider2D`, `EnemyAI`, `Health`.
- `Door` co `Transform`, `SpriteRenderer`, `Animator`, `DoorController`.
- Khong can moi object phai giong nhau.
- Moi object duoc ghep dung theo nhu cau.

## 6. GameObject khong dong nghia voi vat the huu hinh

- GameObject co the la nhan vat hoac vat trang tri.
- GameObject cung co the la mot object logic vo hinh.
- Vi du `GameManager`, `AudioManager`, `SpawnPoint`.
- Nghia la GameObject khong chi de hien hinh anh.
- No la don vi to chuc trong scene.

## 7. Thanh phan bat buoc la Transform

- Moi GameObject deu co `Transform`.
- Khong co `Transform`, Unity khong biet object nam o dau.
- Ngay ca object logic vo hinh cung co vi tri trong scene.
- Dieu nay giai thich vi sao transform xuat hien tren moi object.

## 8. Object co the co nhieu component cung loai khong

- Co nhung component cho phep mot object chi co mot ban.
- Vi du thuong gap la `Transform`.
- Co nhung component co the co nhieu ban trong mot object.
- Tuy component ma quy tac khac nhau.
- Khi hoc script, ban se gap thuoc tinh de gioi han dieu nay.

## 9. Bat tat object va bat tat component

- Tat `GameObject` nghia la ca object va component con bi ngung.
- Tat mot `Component` thi object van ton tai, chi chuc nang do ngung.
- Day la khac biet rat quan trong.
- Vi du tat `Collider` de tam thoi khong va cham.
- Vi du tat ca `GameObject` de panel UI bien mat hoan toan.

## 10. ActiveSelf va ActiveInHierarchy

- `activeSelf` la trang thai do chinh object tu dat.
- `activeInHierarchy` la trang thai thuc te sau khi tinh ca cha.
- Neu object con bat nhung object cha tat, object con van khong hoat dong trong hierarchy.
- Nguoi moi hay nham diem nay khi dung UI va parent child.

## 11. Quan he cha con

- GameObject co the la cha cua object khac.
- Khi object cha di chuyen, object con di theo.
- Khi object cha bi tat, object con thuong bi anh huong theo.
- Trong UI, cau truc cha con rat pho bien.
- Trong nhan vat, vu khi co the la con cua tay nhan vat.

## 12. Component noi chuyen voi nhau the nao

- Script thuong dung `GetComponent<T>()` de lay component khac tren cung object.
- Cung co the lay component tren object con hoac object cha.
- Nhung neu goi qua nhieu lan trong `Update`, co the lam code roi.
- Thuong ta lay reference o `Awake` hoac `Start` roi luu lai.

## 13. GameObject la container, component moi la nang luc

- Khong nen hoi "GameObject nay la loai nao" qua som.
- Nen hoi "No dang co nhung component nao".
- Mot `Enemy` tro thanh enemy vi cac component cua no.
- Mot `Player` tro thanh player vi cac component cua no.
- Day la tu duy component.

## 14. Script cua ban cung la component

- Khi tao class ke thua `MonoBehaviour`, ban dang tao mot component tuy chinh.
- Ban co the gan script do len object tu Inspector.
- Moi object co the co bo du lieu rieng cho cung mot script.
- Day la ly do script rat de tai su dung.

## 15. Vi du thuc te voi nhan vat

- `PlayerMovement` chi lo di chuyen.
- `PlayerHealth` chi lo mau.
- `PlayerAttack` chi lo tan cong.
- `PlayerAnimator` chi lo noi logic voi animation.
- `PlayerInputReader` chi lo doc input.
- Tach ra nhu vay de thay doi de dang hon.

## 16. Dau hieu script dang om qua nhieu viec

- Script vua doc input, vua di chuyen, vua tan cong, vua cap nhat UI.
- Script co hang chuc bien khong lien quan.
- Script phai tham chieu qua nhieu object khac nhau.
- Ban ngai sua vi so hu logic.
- Day la luc nen tach thanh nhieu component.

## 17. Inspector giup ghep component bang mat

- Ban co the keo object tu `Hierarchy` vao truong tham chieu trong Inspector.
- Day la cach rat pho bien de lien ket script.
- Nguoi moi nen tan dung dieu nay truoc khi toi uu hoa kien truc.
- Tuy nhien van phai dat ten bien ro nghia.

## 18. Prefab va component

- Khi tao prefab, ban dang luu cau hinh component cua object.
- Moi instance cua prefab thuong co cung bo component co ban.
- Day giup dong bo enemy, dan, vat pham rat nhanh.
- Sua prefab se lan ra nhieu noi.

## 19. Component hien thi va component logic

- `SpriteRenderer`, `MeshRenderer`, `Animator` thuong gan voi hien thi.
- `Collider`, `Rigidbody` thuong gan voi tuong tac vat ly.
- Script quan ly mau, nhiem vu, trang thai thuong la logic.
- Mot object tot la object co cac lop chuc nang tach nhau ro rang.

## 20. Component khong nen biet qua nhieu

- `Health` khong nen tu biet cach UI ve thanh mau.
- `Movement` khong nen tu biet he thong achievement.
- Moi component nen biet vua du de lam viec cua minh.
- Dieu nay giup giam phu thuoc va de test hon.

## 21. Vi du ve vien dan

- GameObject `Bullet` co the co `Transform`.
- Them `SpriteRenderer` de hien dan.
- Them `Rigidbody2D` neu dung vat ly.
- Them `Collider2D` de va cham.
- Them `BulletDamage` de gay sat thuong.
- Them `AutoReturnToPool` neu ve sau se dung object pooling.

## 22. Vi du ve UI button

- Mot nut UI van la object.
- No co `RectTransform` thay vi transform thong thuong cho bo cuc UI.
- No co `Image` de hien nen.
- No co `Button` de bat su kien bam.
- No co the co script rieng neu can.
- Dieu nay cho thay ca UI cung theo tu duy object va component.

## 23. So sanh voi lap trinh C# thuần

- Trong C# thuần, ban hay tu tao doi tuong bang `new`.
- Trong Unity, rat nhieu doi tuong ton tai nhờ editor va component.
- Ban van viet class, nhung cach dua class vao he thong la gan len GameObject.
- Unity them mot tang lam viec truc quan len tren code.

## 24. Tag va Layer la gi

- `Tag` giup danh dau object theo nhan.
- `Layer` giup phan nhom cho camera, raycast, vat ly.
- Chung khong thay the component.
- Chung la thong tin bo sung de he thong xu ly.
- Khong nen dua qua nhieu logic vao chuoi tag mot cach vo toi va.

## 25. Tim component an toan

- Neu script can mot component bat buoc, hay gan no ro rang.
- Co the lay bang `GetComponent` trong `Awake`.
- Co the keo tha reference tu Inspector.
- Sau khi lay, nen kiem tra null neu co kha nang thieu.
- Console se giup ban phat hien loi reference som.

## 26. Loi thuong gap cua nguoi moi

- Nghi rang GameObject tu no lam duoc moi thu.
- Quen rang script la mot component.
- Dat tat ca logic vao mot script khong lo.
- Khong biet phan biet tat object va tat component.
- Gan nham reference trong Inspector.
- Tao object ten mo ho khong ro chuc nang.

## 27. Cach tu hoi khi thiet ke object

- Object nay can hien gi?
- Object nay can va cham khong?
- Object nay co di chuyen bang vat ly khong?
- Object nay can nghe input khong?
- Object nay can script nao?
- Chuc nang nao nen tach thanh component rieng?

## 28. Bai tap tu duy

- Tu tao mot object `Player` rong.
- Liet ke component toi thieu de no co the di chuyen va mat mau.
- Tu tao mot object `Coin` va liet ke component de no co the duoc nhat.
- Tu tao mot object `Door` va liet ke component de no co the mo bang animation.
- Moi vi du deu nen tach phan hien thi, va cham va logic.

## 29. Cau hoi tu kiem tra

- Vi sao Unity dung component thay vi nhét moi thu vao mot class?
- Vi sao script la component?
- Khac biet giua tat GameObject va tat component?
- Vi sao parent child quan trong?
- Khi nao nen tach them mot component moi?

## 30. Ket noi voi bai Transform

- Sau khi hieu GameObject va Component, bai tiep theo la `Transform`.
- Day la component co mat tren moi object.
- Hieu transform se giup ban dat va dieu khien object dung cach.

## 31. Nen doc object theo bo component

- Nhin vao mot enemy, dung voi hoi ten no la gi truoc.
- Hay xem no co `Renderer`, `Collider`, `Rigidbody`, script nao.
- Tu danh sach do, ban se doan duoc no co the lam gi.
- Day la cach doc mot scene theo tu duy Unity.

## 32. Script va component co moi quan he rat thuc te

- File script trong `Project` la dinh nghia.
- Component script tren object la ban dang chay trong scene.
- Cung mot file script co the duoc gan cho nhieu object.
- Moi object se co bo du lieu rieng.
- Day la ly do mot script co tinh tai su dung rat cao.

## 33. Object logic vo hinh rat quan trong

- Nguoi moi thuong nghi object phai nhin thay duoc.
- Thuc te rat nhieu object logic khong can hinh anh.
- `GameManager`, `SpawnPoint`, `DialogueTrigger`, `AudioManager` la vi du ro rang.
- Chung van la GameObject hop le.
- Vi vay dung dong nhat object voi hinh anh hien tren man hinh.

## 34. Component la cach Unity day ban tu duy module

- Moi chuc nang nho la mot khoi rieng.
- Ban co the them, bot, doi, tat tung khoi.
- Day la cach rat hop voi game, noi object thuong co nhieu mat chuc nang.
- Cung la cach de team chia viec ro rang hon.

## 35. Khi nao nen tach them component

- Khi script da co nhieu bien khong lien quan.
- Khi mot logic co the dung lai o object khac.
- Khi file qua dai va kho doc.
- Khi mot thay doi nho co nguy co lam hu phan khac.
- Khi ban khong the giai thich ro script nay chi lam mot viec gi.

## 36. Component dependency can duoc nghi som

- Script movement co the can rigidbody.
- Script mau co the can UI thanh mau.
- Script tan cong co the can animator.
- Nhung dependency can ro rang, khong mo ho.
- Cang ro rang, cang de debug.

## 37. Thanh phan hien thi va logic nen tach long le

- Renderer chi can lo ve viec hien.
- Script logic chi can quyet dinh khi nao hien, khi nao tat.
- Collider lo ve vung tuong tac.
- Rigidbody lo ve phan vat ly.
- Tach duoc nhu vay, object se ro mat hon.

## 38. Inspector la noi keo cac manh lai

- Co nhung reference duoc lay tu dong bang `GetComponent`.
- Co nhung reference nen duoc gan bang tay trong Inspector.
- Ban can biet chon cach nao gon va an toan hon cho tung truong hop.
- Day la mot phan cua ky nang lam viec voi component.

## 39. Thanh cong cua Unity den tu do ghep

- Ban khong can viet mot he thong khung cho moi object.
- Ban lap rap object nhanh bang component co san va script tu viet.
- Dieu nay rat manh cho prototyping.
- Dong thoi no cung doi hoi ky luat tach trach nhiem.

## 40. Vi du phan tich player bai ban

- `Transform`: vi tri trong scene.
- `SpriteRenderer`: hien nhan vat.
- `Collider2D`: vung va cham.
- `Rigidbody2D`: vat ly.
- `PlayerInput`: doc input.
- `PlayerMovement`: di chuyen.
- `PlayerShooter`: ban dan.
- `Health`: mau.
- `Animator`: animation.

## 41. Vi du phan tich enemy can chien

- `Transform`
- `SpriteRenderer`
- `Collider2D`
- `Rigidbody2D` hoac movement script
- `EnemyPatrol`
- `EnemyAttack`
- `Health`
- `DropLoot`
- `Animator`

## 42. Vi du phan tich coin

- `Transform`
- `SpriteRenderer`
- `Collider2D` dang trigger
- `CoinPickup`
- Co the them `RotateVisual` de quay cho dep
- Co the them `FloatVisual` de nhap nho theo truc Y

## 43. Vi sao object ten dung van chua du

- Ten `EnemyBoss` khong noi het cach no hoat dong.
- Nhin component moi biet no co AI nao, co mau, co vat ly hay khong.
- Ten tot la can.
- Component ro rang moi la du.

## 44. Doc object de debug nhanh

- Object khong di chuyen: xem movement component co dang bat khong.
- Object khong va cham: xem collider co khong.
- Object khong roi: xem rigidbody co khong.
- Object khong hien: xem renderer co khong.
- Object loi logic: xem script nao dang gan tren no.

## 45. Tong ket bo sung

- Unity khuyen khich ban lap rap object tu nhieu thanh phan nho.
- Cang som nghi theo component, ban cang de viet code sach.
- Day la nen tang de hoc transform, scripting, vat ly va AI ve sau.
