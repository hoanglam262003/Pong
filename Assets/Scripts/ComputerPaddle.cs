using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    private void FixedUpdate()
    {
        if (this.ball.linearVelocity.x >= 0f)
        {
            if (this.ball.position.y > this.transform.position.y)
            {
                rb.AddForce(Vector2.up * speed);
            }
            else if (this.ball.position.y < this.transform.position.y)
            {
                rb.AddForce(Vector2.down * speed);
            }
        }
        else
        {
            if (this.transform.position.y > 0f)
            {
                rb.AddForce(Vector2.down * speed);
            }
            else if (this.transform.position.y < 0f)
            {
                rb.AddForce(Vector2.up * speed);
            }
        }
    }
}
