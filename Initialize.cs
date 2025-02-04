    private void Start()
    {
       
        isTurning = false;
    }

    private void ResetRotation()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
