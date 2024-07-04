import android.app.Activity;
import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemSelectedListener;
import android.widget.AnalogClock;
import android.widget.ArrayAdapter;
import android.widget.DigitalClock;
import android.widget.Spinner;
@SuppressWarnings("deprecation")
public class ClockActivity extends Activity implements OnItemSelectedListener
{
String[] colours={"Yellow","blue","Green"};
Spinner spin;
AnalogClock an;
@SuppressWarnings("deprecation")
DigitalClock dg;
@SuppressWarnings("deprecation")
@Override
protected void onCreate(Bundle savedInstanceState)
{
super.onCreate(savedInstanceState);
setContentView(R.layout.activity_clock);
an=(AnalogClock)findViewById(R.id.analogClock1);
dg=(DigitalClock)findViewById(R.id.digitalClock1);
spin=(Spinner)findViewById(R.id.spinner1);
spin.setOnItemSelectedListener(this);
ArrayAdapter<?> aa=new

ArrayAdapter<Object>(this,android.R.layout.simple_spinner_item,colours);

aa.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item)
; spin.setAdapter(aa);
}
@Override
public void onItemSelected(AdapterView<?> arg0, View arg1, int arg2,

long agr3) {
// TODO Auto-generated method stub
switch(arg2)
{
case 0: dg.setBackgroundColor(Color.YELLOW);
an.setBackgroundColor(Color.YELLOW);
break;

case 1: dg.setBackgroundColor(Color.BLUE);
an.setBackgroundColor(Color.BLUE);
break;
case 2: dg.setBackgroundColor(Color.GREEN);
an.setBackgroundColor(Color.GREEN);
break;
}
}
@Override
public void onNothingSelected(AdapterView<?> parent)
{ // TODO Auto-generated method stub
}

}