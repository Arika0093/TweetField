using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

// -----------------------------------------------
//	From: http://d.hatena.ne.jp/among_ev/20110306
//		: http://d.hatena.ne.jp/among_ev/20110320/1300593343
// -----------------------------------------------
namespace TweetField
{
	/// <summary>
	/// フォームをドラッグして移動するクラス
	/// </summary>
	class FormDragMover
	{
		// 移動の対象となるフォーム
		Form moveForm;

		// 移動中を表す状態
		bool moveStatus;

		// ドラッグを無効とする幅（フォームの端をサイズ変更に使うときなど）
		int noDragAreaWidth;

		// 標準のカーソル
		Cursor defaultCursor;

		// マウスをクリックした位置
		Point lastMouseDownPoint;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="moveForm">移動の対象となるフォーム</param>
		/// <param name="noDragAreaWidth">ドラッグを無効とする幅</param>
		public FormDragMover(Form moveForm, int noDragAreaWidth)
		{
			this.moveForm = moveForm;
			this.noDragAreaWidth = noDragAreaWidth;

			// 現時点でのカーソルを保存しておく
			defaultCursor = moveForm.Cursor;

			// イベントハンドラを追加
			AddEventHandler(moveForm);
		}

		/// <summary>
		/// イベントハンドラ追加
		/// </summary>
		/// <param name="Ctrl">追加対象</param>
		public void AddEventHandler(Control Ctrl){
			Ctrl.MouseDown += new MouseEventHandler(moveForm_MouseDown);
			Ctrl.MouseMove += new MouseEventHandler(moveForm_MouseMove);
			Ctrl.MouseUp += new MouseEventHandler(moveForm_MouseUp);
		}

		/// <summary>
		/// マウスボタン押下イベントハンドラ
		/// </summary>
		void moveForm_MouseDown(object sender, MouseEventArgs e)
		{
			// 左クリック時のみ処理する。左クリックでなければ何もしない
			if ((e.Button & MouseButtons.Left) != MouseButtons.Left) return;

			// 移動が有効になる範囲
			// 例えばフォームの端から何ドットかをサイズ変更用の領域として使用する場合、
			// そこを避けるために使う。
			Rectangle moveArea = new Rectangle(
				noDragAreaWidth, noDragAreaWidth,
				moveForm.Width - (noDragAreaWidth * 2), moveForm.Height - (noDragAreaWidth * 2));

			// クリックした位置が移動が有効になる範囲であれば、移動中にする
			if (moveArea.Contains(moveForm.PointToClient(Control.MousePosition)))
			{
				// 移動中にする
				moveStatus = true;

				// クリックしたポイントを保存する
				lastMouseDownPoint = moveForm.PointToClient(Control.MousePosition);

				// マウスキャプチャー
				moveForm.Capture = true;
			}
			else
			{
				moveStatus = false;
			}
		}

		/// <summary>
		/// マウス移動イベントハンドラ
		/// </summary>
		void moveForm_MouseMove(object sender, MouseEventArgs e)
		{
			// 移動中の場合のみ処理。移動中でなければ何もせず終わる
			if (moveStatus == false) return;

			// 左ボタン押下中のみ処理する。押下中ではないときは何もしない。
			if ((e.Button & MouseButtons.Left) != MouseButtons.Left) return;

			// マウスカーソルの変更
			moveForm.Cursor = Cursors.SizeAll;


			// 移動先のフォーム位置
			Rectangle newPosition = new Rectangle(
				moveForm.Left,
				moveForm.Top,
				moveForm.Width,
				moveForm.Height);
	
			// フォームの移動
			//*//通常の場合
			newPosition.X += e.X - lastMouseDownPoint.X;
			newPosition.Y += e.Y - lastMouseDownPoint.Y;
			//*/

			// 吸着するサイズ
			Size gap = new Size(16, 16);
			// */
			// 判定用のRECT
			Rectangle newRect = new Rectangle();

			// 作業領域の取得（この作業領域の内側に吸着する）
			Size area = new Size(
				System.Windows.Forms.Screen.GetWorkingArea(moveForm).Width,
				System.Windows.Forms.Screen.GetWorkingArea(moveForm).Height);

			// 画面端の判定用（画面の端の位置に、吸着するサイズ分のRECTを定義する）
			Rectangle rectLeft = new Rectangle(
										0,
										0,
										gap.Width,
										area.Height);
			Rectangle rectTop = new Rectangle(
										0,
										0,
										area.Width,
										gap.Height);
			Rectangle rectRight = new Rectangle(
										area.Width - gap.Width,
										0,
										gap.Width,
										area.Height);
			Rectangle rectBottom = new Rectangle(
										0,
										area.Height - gap.Height,
										area.Width,
										gap.Height);
			// 衝突判定
			// 判定用のRECTを自分のウィンドウの隅に重ねるように移動し、
			// 画面端の判定用のRECTと衝突しているかチェックする。
			// 衝突していた場合は、吸着させるように移動する

			// 左端衝突判定
			{
				newRect = newPosition;
				newRect.Width = gap.Width;

				if (newRect.IntersectsWith(rectLeft))
				{
					// 左端に吸着させる
					newPosition.X = 0;
				}
			}
			// 右端衝突判定
			{
				newRect = newPosition;
				newRect.X = newPosition.Right - gap.Width;  // ウィンドウの右隅
				newRect.Width = gap.Width;

				if (newRect.IntersectsWith(rectRight))
				{
					// 右端に吸着させる
					newPosition.X = area.Width - moveForm.Width;
				}
			}
			// 上端衝突判定
			{
				newRect = newPosition;
				newRect.Height = gap.Height;

				if (newRect.IntersectsWith(rectTop))
				{
					// 上端に吸着させる
					newPosition.Y = 0;
				}
			}
			// 下端衝突判定
			{
				newRect = newPosition;
				newRect.Y = newPosition.Bottom - gap.Height; // ウィンドウの下端
				newRect.Height = gap.Height;

				if (newRect.IntersectsWith(rectBottom))
				{
					// 下端に吸着させる
					newPosition.Y = area.Height - moveForm.Height;
				}
			}

			// 実際に移動させる
			moveForm.Left = newPosition.Left;
			moveForm.Top = newPosition.Top;
		}

		/// <summary>
		/// マウスボタン押上イベントハンドラ
		/// </summary>
		void moveForm_MouseUp(object sender, MouseEventArgs e)
		{
			// 左ボタンのみ処理する。左ボタンではないときは何もしない。
			if ((e.Button & MouseButtons.Left) != MouseButtons.Left) return;

			// 移動を終了する
			moveStatus = false;

			// マウスキャプチャーを終了する
			moveForm.Capture = false;
		}
	}
}
