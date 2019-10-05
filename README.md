# Picidae-Auto-Tester

![C#](https://img.shields.io/badge/Language-C%23-yellow) ![Licence](https://img.shields.io/badge/Licence-MIT-blue) ![Platfrom](https://img.shields.io/badge/Platform-Windows-brightgreen) ![Framework](https://img.shields.io/badge/Framework-.Net_%20Framework%204.7-red)

![](https://i.imgur.com/m9T2aMX.png)

## 다운로드

|Build Date|Version|Link|
|:---:|:---:|:---:|
|2019.10.05|0.8| [Download]() |

## Picidae Auto Tester 소개

Picidae Auto Tester는 Windows 응용프로그램의 자동 테스트를 위한 도구입니다.
특히 Kiosk와 같이 전체 화면으로 서비스되는 환경의 소프트웨어를 테스트하기 좋습니다.
한 번의 워크플로우 작성으로 수십 개의 장비에서 수십 번의 User Level 테스트를 진행할 수 있습니다.

## Picidae Auto Tester의 기능
Picidae Auto Tester는 다음과 같은 기능을 제공합니다.
- 마우스 이벤트 (클릭, 이동, 드래그)
- 키보드 이벤트
- 스크린샷 (자동저장)
- 로깅

### 로깅
**Picidae Auto Tester의 로깅 기능은 다음의 정보를 자동으로 기록합니다.**

사용자가 작성한 이벤트에 따라서 남겨지는 정보는 다음과 같습니다.
- 이벤트 번호
- 시간
- 이벤트 이름
- 좌표
- 수행시간
- 입력 문자열
- 태그

Picidae Auto Tester는 현재 마우스의 좌표에서 실행되는 최상위 프로세스를 찾아 아래의 정보를 기록합니다.
- 윈도우 클래스
- 윈도우 캡션
- 컨트롤 타입
- 컨트롤 네임

사용자는 txt 또는 csv 형식의 파일로 위의 정보를 제공받을 수 있습니다.

## 설명서
더 자세한 정보와 사용 설명서를 [이 링크]()에서 볼 수 있습니다.

## 오픈소스 라이센스 정보

- [Dragging items in a ListView control with visual insertion guides](http://www.cyotek.com/blog/dragging-items-in-a-listview-control-with-visual-insertion-guides)