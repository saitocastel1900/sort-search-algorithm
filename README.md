# sort-search-algorithm
C#で実装した代表的なアルゴリズムです。ご自由にお使いください。

## 探索
#### グラフ探索

**・幅優先探索**  

**・深さ優先探索**  

**・A***  

#### リスト探索
**・線形探索**  
-先頭から一から順に目的の値と比較して探す  
-所謂全検索  
-時間計算量はO(n)  

**・二分探索**  
-ソート済みのコレクションを中央値の大小関係を比較して目的の値がどちらの方向にあるのか絞る。このサイクルを繰り返して目的の値を探す    
-時間計算量はo(log2(n))  

**・ハッシュ表探索**  

## ソート
**・選択ソート**  
-線形探索を行いコレクションの最小値を探索。見つけた最小値を端に置く。このサイクルを繰り返す  
-全検索  
-計算量はo(n^2)  

**・挿入ソート**  
-昇順に並び替える場合、左から順に値を比較する(i[0]<i[1]...)  
計算量はO(n2)  

**・バブルソート**  
-隣り合う者同士の値を比較し、値を入れ替える  
-全検索  
-計算量はO(n2)  

**・クイックソート**  

**・ヒープソート**  
-ヒープというグラフにコレクションを降順で格納(降順ヒープ)。後はヒープから値を取り出すだけで降順にソートされたコレクションが得られる
-根は要素なの最大値(親の数値は子よりも大きい)  
-要素は左詰め  
-計算量はo(log n)  

**・マージソート**  

**・シェルソート**  

**・パケットソート**  

**・基数ソート**  

**・ボコソート**  

## 暗号化
**・AES**  
-  
-  

**・XOR**  
-Byteを使って変換したものをXORでキー文字列と組み合わせることで暗号化   
-性質としてXORを二回通すと元の値が得られる  
-共通暗号方式の基礎として使われている  

**・ハッシュ化**  

## その他
**・FizzBuzz**  
-3の倍数で"Fizz"を出力  
-5の倍数で"Buzz"を出力  
-3と5の公倍数は"Fizz Buzz"を出力  

**・素数判定**  
-１と自分自身以外で割り切れない整数  
-ある数と平方根までに約数があるかでも素数かが得られる  
-エラトステネスの篩から合成数は素数でないことを利用してみる  
-フェルマーテスト  

＊合成数（素数でない数値）

**・素因数分解**  


**・フィボナッチ数列**  


**・ユークリッドの互除法**  


**・ナップザック問題**  


**・ハノイの塔**


**・分和問題**  


**・分割数**  


**・重複組み合わせ**  


**・最長共通部分列問題**  

# 参考
蟻本：https://book.mynavi.jp/ec/products/detail/id=22672  
素数判定：https://qiita.com/asksaito/items/76b71602dd956b79dbf7  
AES:https://developers.wonderpla.net/entry/2016/08/02/141000  
数学的思考https://atcoder.jp/contests/math-and-algorithm  
