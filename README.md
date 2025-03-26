# Unity 인벤토리 구현
  내일배움캠프 심화과제 개인프로젝트

  ## 인벤토리 구현
  > 내일배움캠프 Unity 심화주차 개인 프로젝트 2025.03.19 ~ 2025.03.26
  > 게임 내 메인화면, 인벤토리, 캐릭터 상태보기 창이 구현되어 있습니다.

  ## 기술 스택
- Unity 2022.3.17f1
- C#

## 주요 기능
### 🏛️메인 화면
<img src="https://velog.velcdn.com/images/ehddud9608/post/8dd5bf3e-9877-44c6-99d4-6827091f1d54/image.png">

기본적인 캐릭터의 정보와 설명, 획득한 골드와 인벤토리 창 및 캐릭터상태 창으로 이동이 가능한 화면입니다.

### 🎒인벤토리
<img src="https://velog.velcdn.com/images/ehddud9608/post/3302ca43-cf33-42df-a87d-ee9d774c80b3/image.png" width ="700">
<img src="https://velog.velcdn.com/images/ehddud9608/post/2baa92c0-82de-40a5-8dce-9d20384df00a/image.png" width = "700">

획득한 아이템은 인벤토리의 슬롯창에 표시되며, 슬롯은 아이템이 획득함에 따라 생성되고, 개수로 표시됩니다.<br>
아이템을 클릭 시 아이템정보 팝업이 표시되고, 장착하지 않은 아이템은 장착버튼이 장착한 아이템은 해제버튼이 표시됩니다. <br>
또한 아이템 장착시 인벤토리 창에 장착한 아이템에 [E]로 표시되고, 아이템은 각 부위에 맞춰 1개씩만 장착이 가능합니다.

### ❤️캐릭터 상태
<img src="https://velog.velcdn.com/images/ehddud9608/post/678cb5e6-59df-4c06-bb1f-ed4f7bbfa1e6/image.png" width = "700">
<img src="https://velog.velcdn.com/images/ehddud9608/post/00b13c25-5f1c-4276-8f74-85719db29763/image.png" width ="700">
아이템을 장착하지 않았을 때에는 캐릭터 정보창에 기본 능력치로 표시되며, 아이템을 장착시 장착한 아이템의 능력치만큼 향상된 것으로 표시됩니다. <br>
인벤토리 창과 캐릭터 상태창은 추후 보유한 아이템이 증가하거나, 캐릭터의 능력치가 추가될 경우를 생각하여 Scroll View를 통해 마우스를 휠로 움직여 많은 정보를 보여줄 수 있도록 구현하였습니다.

## 라이선스
| 에셋 이름     |출처| 라이선스        |
|:-----------:|:---:|:-------------:|
|110 Free Armor And Jewelry Icons|https://assetstore.unity.com/packages/2d/gui/icons/110-free-armor-and-jewelry-icons-243902| CC0 |
|Fantasy Wooden GUI : Free|https://assetstore.unity.com/packages/2d/gui/fantasy-wooden-gui-free-103811| CC0|
| Critical Icon |   https://www.flaticon.com/free-icon/critical-damage_1496059?term=critical+attack&page=1&position=5&origin=search&related_id=1496059| CC0 |
| Attack Icon |https://www.flaticon.com/free-icon/battle_3522092?term=attack&page=1&position=18&origin=search&related_id=3522092| CC0 |
| Defense Icon |    https://www.flaticon.com/free-icon/shield_929429?term=defense&page=1&position=9&origin=search&related_id=929429| CC0 |
| Health Icon|https://www.flaticon.com/free-icon/cardiogram_3004458?term=health&page=1&position=21&origin=search&related_id=3004458| CC0 |
| Low Poly RPG Fantasy Weapons Lite|https://assetstore.unity.com/packages/3d/props/weapons/low-poly-rpg-fantasy-weapons-lite-226554| CC0 |