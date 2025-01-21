using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns._03___Behavioral._3._1_Command;

public abstract class Commander
{
    public abstract void Executar();
    public abstract void Desfazer();
}
